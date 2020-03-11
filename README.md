# <p align='center'> SneakersBiip Monitoring API (Beta) </p> #

----------


### SneakersBiip offers users centralized monitoring API which can help bots to get instant updates on sneaker products from all popular shop. This way bots will no more need to send requests and parse html each second for monitoring shop (which requires proxies, fast network connection and much processing power). ###
<br/> 
 

### We Offer **SignalR** API: Compared to HTTP SignalR is much faster for given task, as client can instantly get updated from server instead of sending requests frequently and waiting from response.

<br/>
<br/>

## <p align='center'>SignalR API Implementation Instruction For Developers (C#) </p> ##



1. Install **SneakersBiip_SDK** from nuget
2. Add this code at your application start (for example Main() method):
 ```csharp
    NotificationListener.ApiToken = "lulknisfblrtwzuaiuwmvblyrvdyjm"; // (beta token). As currently api in in beta, consuming it is free.
    NotificationListener.NotificationReceived += product =>
    {
        /*handle product here. product variable contains all information about product: 
        (link, title, imagelink, shopLink, sizes, notificationtype (release or restock)) */
    };
 ```
