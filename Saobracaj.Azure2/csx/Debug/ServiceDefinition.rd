<?xml version="1.0" encoding="utf-8"?>
<serviceModel xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance" xmlns:xsd="http://www.w3.org/2001/XMLSchema" name="Saobracaj.Azure2" generation="1" functional="0" release="0" Id="1a29aa28-ee2d-472c-a790-e5ef325c9c4a" dslVersion="1.2.0.0" xmlns="http://schemas.microsoft.com/dsltools/RDSM">
  <groups>
    <group name="Saobracaj.Azure2Group" generation="1" functional="0" release="0">
      <componentports>
        <inPort name="Saobracaj:Endpoint1" protocol="http">
          <inToChannel>
            <lBChannelMoniker name="/Saobracaj.Azure2/Saobracaj.Azure2Group/LB:Saobracaj:Endpoint1" />
          </inToChannel>
        </inPort>
      </componentports>
      <settings>
        <aCS name="Saobracaj:Microsoft.WindowsAzure.Plugins.Diagnostics.ConnectionString" defaultValue="">
          <maps>
            <mapMoniker name="/Saobracaj.Azure2/Saobracaj.Azure2Group/MapSaobracaj:Microsoft.WindowsAzure.Plugins.Diagnostics.ConnectionString" />
          </maps>
        </aCS>
        <aCS name="SaobracajInstances" defaultValue="[1,1,1]">
          <maps>
            <mapMoniker name="/Saobracaj.Azure2/Saobracaj.Azure2Group/MapSaobracajInstances" />
          </maps>
        </aCS>
      </settings>
      <channels>
        <lBChannel name="LB:Saobracaj:Endpoint1">
          <toPorts>
            <inPortMoniker name="/Saobracaj.Azure2/Saobracaj.Azure2Group/Saobracaj/Endpoint1" />
          </toPorts>
        </lBChannel>
      </channels>
      <maps>
        <map name="MapSaobracaj:Microsoft.WindowsAzure.Plugins.Diagnostics.ConnectionString" kind="Identity">
          <setting>
            <aCSMoniker name="/Saobracaj.Azure2/Saobracaj.Azure2Group/Saobracaj/Microsoft.WindowsAzure.Plugins.Diagnostics.ConnectionString" />
          </setting>
        </map>
        <map name="MapSaobracajInstances" kind="Identity">
          <setting>
            <sCSPolicyIDMoniker name="/Saobracaj.Azure2/Saobracaj.Azure2Group/SaobracajInstances" />
          </setting>
        </map>
      </maps>
      <components>
        <groupHascomponents>
          <role name="Saobracaj" generation="1" functional="0" release="0" software="C:\Users\Emina\documents\visual studio 2015\Projects\Saobracaj\Saobracaj.Azure2\csx\Debug\roles\Saobracaj" entryPoint="base\x64\WaHostBootstrapper.exe" parameters="base\x64\WaIISHost.exe " memIndex="-1" hostingEnvironment="frontendadmin" hostingEnvironmentVersion="2">
            <componentports>
              <inPort name="Endpoint1" protocol="http" portRanges="80" />
            </componentports>
            <settings>
              <aCS name="Microsoft.WindowsAzure.Plugins.Diagnostics.ConnectionString" defaultValue="" />
              <aCS name="__ModelData" defaultValue="&lt;m role=&quot;Saobracaj&quot; xmlns=&quot;urn:azure:m:v1&quot;&gt;&lt;r name=&quot;Saobracaj&quot;&gt;&lt;e name=&quot;Endpoint1&quot; /&gt;&lt;/r&gt;&lt;/m&gt;" />
            </settings>
            <resourcereferences>
              <resourceReference name="DiagnosticStore" defaultAmount="[4096,4096,4096]" defaultSticky="true" kind="Directory" />
              <resourceReference name="EventStore" defaultAmount="[1000,1000,1000]" defaultSticky="false" kind="LogStore" />
            </resourcereferences>
          </role>
          <sCSPolicy>
            <sCSPolicyIDMoniker name="/Saobracaj.Azure2/Saobracaj.Azure2Group/SaobracajInstances" />
            <sCSPolicyUpdateDomainMoniker name="/Saobracaj.Azure2/Saobracaj.Azure2Group/SaobracajUpgradeDomains" />
            <sCSPolicyFaultDomainMoniker name="/Saobracaj.Azure2/Saobracaj.Azure2Group/SaobracajFaultDomains" />
          </sCSPolicy>
        </groupHascomponents>
      </components>
      <sCSPolicy>
        <sCSPolicyUpdateDomain name="SaobracajUpgradeDomains" defaultPolicy="[5,5,5]" />
        <sCSPolicyFaultDomain name="SaobracajFaultDomains" defaultPolicy="[2,2,2]" />
        <sCSPolicyID name="SaobracajInstances" defaultPolicy="[1,1,1]" />
      </sCSPolicy>
    </group>
  </groups>
  <implements>
    <implementation Id="bf2ed5ff-1836-4475-a2f5-929c0d21e0da" ref="Microsoft.RedDog.Contract\ServiceContract\Saobracaj.Azure2Contract@ServiceDefinition">
      <interfacereferences>
        <interfaceReference Id="377ff15d-3437-4935-8854-6431b68cbf45" ref="Microsoft.RedDog.Contract\Interface\Saobracaj:Endpoint1@ServiceDefinition">
          <inPort>
            <inPortMoniker name="/Saobracaj.Azure2/Saobracaj.Azure2Group/Saobracaj:Endpoint1" />
          </inPort>
        </interfaceReference>
      </interfacereferences>
    </implementation>
  </implements>
</serviceModel>