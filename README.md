# TPManager, A dashboard for TP-Link modems.

![Showcase.gif](/Showcase.gif)

## Table of Contents

* [Summary](#Summary)

* [Supported Devices](#Supported-Devices)

* [Technologies](#Technologies)

* [Features](#Features)

* [End-Points](#End-Points)

* [Structure](#Structure)

* [Usage and Installation](#usage-and-installation)

## Summary

TPManager is an application I made to add some missing functionality to my TPLink modem.

It allows me to quickly change settings as well as do a lot of maintenance with a few clicks. 

## Supported Devices

At the moment I only tried it on my own device a **TD-W8968 v5.**  
I am sure many other devices are compatible but I can't guarantee it.  
If you would like to me to support your device then maybe we can cooperate on implementing it.

## Technologies

100% vanilla C#. I made sure not to rely on any external libraries.  
I implemented my own logic for parsing the JSON data (for comparing your speed to international averages).   
My own parser for the javascript/HTML to parse the modem data.  
My own serializer for the userdata.
and my own theme engine for a global light/dark mode.

All the calls to the device are asynchronous and without main thread interruptions. 

## Features

1. A detailed dashboard with most relevant information presented.

2. Quick actions, allowing you to do important operations with a single click.

3. The ability to have full control over your MAC filter.

4. The ability to tag MAC address in your filter (The functionality I originaly made this app for)

5. Compare your current speed to current international averages **(data pulled from speedtest.net)**

6. View hidden WIFI paramters and settings, otherwise hidden by the device.

7. View connected device and copy their MAC addresses to easily add them to the filter

8. Toolbox menue with essential one click configurations with full explination and logging of operations.

9. Troubleshooting menue with essential one click fixes with full explination and logging of operations.

10. Serialized settings for one click login.

11. Darkmode!

## End-Points

If you would like to extend the connector class or simply curious on how it works.  
The modem has a few end points for doing operations which I had to find one by one.  
They return the data as a mixture between HTML and Javascript objects and need to be parsed.

### Getting Data

| End-Point  | Returns |
| ------------- |:-------------:|
| /wlcfg.html      | WIFI information     |
| /wlsecurity.html      | WIFI security information     |
| /upnpcfg.html      | UPNP information     |
| /info.html      | Comprehensive device and internet information     |
| /wlmacflt.cmd      | Returns a list of devices in the MAC filter    |
| /dhcpinfo.html      | Returns a list of leased and connected device    |
| /qosqmgmt.html      | Returns whether or not QOS is enabled and its current Defmark    |

### Actions

| End-Point  | Function | Paramters | Example |
| ------------- |:-------------:|:-------------:|:-------------:|
| /wlcfg.wl     | Enable/Disable WIFI     |WIFI Index: wlSsidIdx, Enable/Disable: wlEnbl| ?wlSsidIdx=0&wlEnbl=1
| /wlcfg.wl     | Set WIFI name    |WIFI Index: wlSsidIdx, Name: wlSsid| ?wlSsidIdx=0&wlSsid=NewWifiName
| /upnpcfg.cgi     | Enable/Disable UPNP     | Enable/Disable: enblUpnp | ?enblUpnp=1
| /dnscfg.cgi      | Set DNS servers     | Primary Server : dnsPrimary, Secondary Server: dnsSecondary | ?dnsPrimary=1.1.1.1&dnsSecondary=8.8.8.8
| /wlsecurity.wl      | Wireless Security mainly WPS     | Disable WPS: wl_wsc_mode | ?wl_wsc_mode=disabled
| /qosmgmt.cmd      | Enable/Disable QoS and set the Defmark    | Enable/Disable : enblQos, Set Defmark: defaultDscpMark | ?&enblQos=1&defaultDscpMark=56
| /rebootinfo.cgi      | Reboot the device    | None | /rebootinfo.cgi
| /wlmacflt.cmd      | Change MAC filter mode    | Filtering Mode: wlFltMacMode | wlFltMacMode=allow
| /wlmacflt.cmd      | Add device to MAC filter    | Device Address: wlFltMacAddr | ?wlFltMacAddr=2F:75:B4:A9:43:C6
| /wlmacflt.cmd      | Remove device from MAC filter    | Device Address: rmLst | ?rmLst=2F:75:B4:A9:43:C6


#### Important Note:

Alongside authenticating the user with a base64 encrypted password.   
all subsequent **actions** require an ever changing session key to be grabbed and submitted as an end pramater. for Ex.
```
http://192.168.1.1/wlcfg.wl?wlSsidIdx=0&wlEnbl=1&wlSsid=MyNewWifiName&2529419906
```
Is a command to change the name of the first WIFI device. The session key here for example is **2529419906**. without it the request will fail.



## Structure
```
+---Classes
|   |   Theme.cs
|   |   
|   +---RouterParser
|   |       RouterActions.cs
|   |       RouterConnector.cs
|   |       RouterInfo.cs
|   |       
|   \---SettingsSerializer
|           SettingsModel.cs
|           SettingsSerializer.cs
|           
+---Enums
|       CountryEnum.cs
|       InfoEnum.cs
|       MACEnum.cs
|       QosEnum.cs
|       
+---Extensions
|       RichTextBoxExtension.cs
|       StringExtension.cs
|       
+---Forms
|   |   Login.cs
|   |   Main.cs
|   |   
|   +---Advanced Settings
|   |       Settings.cs
|   |       Toolbox.cs
|   |       Troubleshooting.cs
|   |       
|   +---Quick Settings
|   |       SpeedComparison.cs
|   |       
|   \---WIFI Settings
|       |   ConnectedDevices.cs
|       |   WIFIAdvInfo.cs
|       |   
|       \---MAC Filter
|               MACAdd.cs
|               MACMain.cs
|               MacTag.cs
|               MACToggle.cs
        
```

## Usage and Installation

**Everything is included in the project. Fork away!**

