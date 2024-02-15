
# Tenjin Implementation in Android for AppLovin
<br/>

- Download and import the Tenjin Unity Package from [here](https://github.com/tenjin/tenjin-unity-sdk/releases). <br/> 
- Add the following lines in the Android Manifest: <br/>

  ```
  <uses-permission android:name="android.permission.INTERNET" /> 
  <uses-permission android:name="android.permission.ACCESS_NETWORK_STATE" />
  <uses-permission android:name="com.google.android.gms.permission.AD_ID"/>
  ```
<p align="center">
    <img src="https://github.com/symoose/TenjinImplementation/assets/160117832/2a9263fb-0637-49a5-aac8-27052e883132">
</p>

- Now, add the following dependencies in your mainTemplate.gradle file

  ```
  dependencies {
    implementation 'com.google.android.gms:play-services-ads-identifier:{version}'
    implementation 'com.android.installreferrer:installreferrer:{version}'
  }
  ```
  <p align="center">
    <img src="https://github.com/symoose/TenjinImplementation/assets/160117832/98bb0363-aeaa-4411-9f8f-654520520f98">
</p> 

- Download the TenjinInit.cs file from this repo and add it to your AdsInitializer plugin <br/>

- In the TenjinInit file, go to the **TenjinConnect** function, and add your key as a string where *instance* is being created <br/>

   <p align="center">
    <img src="https://github.com/symoose/TenjinImplementation/assets/160117832/23515b79-4ce7-4131-8295-1e88223bc357">
</p> 


- Add *tenjin_applovin_enabled* as a scripting symbol


## For Testing
- Make sure your logcat shows the following logs or something similar:


  <p align="center">
    <img src="https://github.com/symoose/TenjinImplementation/assets/160117832/719f3536-e2fa-46ba-831b-1453c55dd533">
</p> 

<p align="center">
    <img src="https://github.com/symoose/TenjinImplementation/assets/160117832/16c357e0-d11f-4475-8435-52c6304d7dd9">
</p> 

## Additional Info

- Unity might get stuck in an infinite loop when importing the Tenjin Unity Package. Untick **Editor** folder to solve the issue

 <p align="center">
    <img src="https://github.com/symoose/TenjinImplementation/assets/160117832/f8d78a4d-bad8-4420-b7d5-2b43cf89b19b">
</p> 


