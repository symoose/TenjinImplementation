
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






