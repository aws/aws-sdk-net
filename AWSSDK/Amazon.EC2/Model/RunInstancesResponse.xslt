<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform" xmlns:ec2="default-ec2-namespace" exclude-result-prefixes="ec2">
  <xsl:output method="xml" omit-xml-declaration="no" indent="yes"/>

  <xsl:template match="ec2:RunInstancesResponse">
    <xsl:element name="RunInstancesResponse">
      <xsl:element name="ResponseMetadata">
        <xsl:element name="RequestId">
          <xsl:value-of select="ec2:requestId"/>
        </xsl:element>
      </xsl:element>
      <xsl:element name="RunInstancesResult">
        <xsl:element name="Reservation">
          <xsl:element name="ReservationId">
            <xsl:value-of select="ec2:reservationId"/>
          </xsl:element>
          <xsl:element name="OwnerId">
            <xsl:value-of select="ec2:ownerId"/>
          </xsl:element>
          <xsl:element name="RequesterId">
            <xsl:value-of select="ec2:requesterId"/>
          </xsl:element>
          <xsl:apply-templates select="ec2:groupSet"/>
          <xsl:apply-templates select="ec2:instancesSet"/>
        </xsl:element>
      </xsl:element>
    </xsl:element>
  </xsl:template>
  
  <xsl:template match="ec2:groupSet">
    <xsl:for-each select="ec2:item">
      <xsl:element name="GroupName">
        <xsl:value-of select="ec2:groupName"/>
      </xsl:element>
      <xsl:element name="GroupId">
        <xsl:value-of select="ec2:groupId"/>
      </xsl:element>
    </xsl:for-each>
  </xsl:template>
  
  <xsl:template match="ec2:instancesSet">
    <xsl:for-each select="ec2:item">
      <xsl:element name="RunningInstance">
        <xsl:element name="InstanceId">
          <xsl:value-of select="ec2:instanceId"/>
        </xsl:element>
        <xsl:element name="ImageId">
          <xsl:value-of select="ec2:imageId"/>
        </xsl:element>
        <xsl:apply-templates select="ec2:instanceState"/>
        <xsl:element name="PrivateDnsName">
          <xsl:value-of select="ec2:privateDnsName"/>
        </xsl:element>
        <xsl:element name="PublicDnsName">
          <xsl:value-of select="ec2:dnsName"/>
        </xsl:element>
        <xsl:element name="StateTransitionReason">
          <xsl:value-of select="ec2:reason"/>
        </xsl:element>
        <xsl:element name="KeyName">
          <xsl:value-of select="ec2:keyName"/>
        </xsl:element>
        <xsl:element name="AmiLaunchIndex">
          <xsl:value-of select="ec2:amiLaunchIndex"/>
        </xsl:element>
        <xsl:apply-templates select="ec2:productCodes"/>
        <xsl:element name="InstanceType">
          <xsl:value-of select="ec2:instanceType"/>
        </xsl:element>
        <xsl:element name="LaunchTime">
          <xsl:value-of select="ec2:launchTime"/>
        </xsl:element>
        <xsl:element name="Placement">
          <xsl:element name="AvailabilityZone">
            <xsl:value-of select="ec2:placement/ec2:availabilityZone"/>
          </xsl:element>
          <xsl:element name="GroupName">
            <xsl:value-of select="ec2:placement/ec2:groupName"/>
          </xsl:element>
          <xsl:element name="Tenancy">
            <xsl:value-of select="ec2:placement/ec2:tenancy"/>
          </xsl:element>
        </xsl:element>
        <xsl:element name="KernelId">
          <xsl:value-of select="ec2:kernelId"/>
        </xsl:element>
        <xsl:element name="RamdiskId">
          <xsl:value-of select="ec2:ramdiskId"/>
        </xsl:element>
        <xsl:element name="Platform">
          <xsl:value-of select="ec2:platform"/>
        </xsl:element>
        <xsl:element name="SubnetId">
          <xsl:value-of select="ec2:subnetId"/>
        </xsl:element>
        <xsl:element name="VpcId">
          <xsl:value-of select="ec2:vpcId"/>
        </xsl:element>
        <xsl:element name="PrivateIpAddress">
          <xsl:value-of select="ec2:privateIpAddress"/>
        </xsl:element>
        <xsl:element name="IpAddress">
          <xsl:value-of select="ec2:ipAddress"/>
        </xsl:element>
        <xsl:element name="Monitoring">
          <xsl:element name="MonitoringState">
            <xsl:value-of select="ec2:monitoring/ec2:state"/>
          </xsl:element>
        </xsl:element>
        <xsl:apply-templates select="ec2:stateReason"/>
        <xsl:element name="Architecture">
          <xsl:value-of select="ec2:architecture"/>
        </xsl:element>
        <xsl:element name="RootDeviceType">
          <xsl:value-of select="ec2:rootDeviceType"/>
        </xsl:element>
        <xsl:element name="RootDeviceName">
          <xsl:value-of select="ec2:rootDeviceName"/>
        </xsl:element>
        <xsl:apply-templates select="ec2:blockDeviceMapping"/>
        <xsl:element name="InstanceLifecycle">
          <xsl:value-of select="ec2:instanceLifecycle"/>
        </xsl:element>
        <xsl:element name="SpotInstanceRequestId">
          <xsl:value-of select="ec2:spotInstanceRequestId"/>
        </xsl:element>
        <xsl:element name="VirtualizationType">
          <xsl:value-of select="ec2:virtualizationType"/>
        </xsl:element>
        <xsl:element name="ClientToken">
          <xsl:value-of select="ec2:clientToken"/>
        </xsl:element>
        <xsl:element name="Hypervisor">
          <xsl:value-of select="ec2:hypervisor"/>
        </xsl:element>
        <xsl:apply-templates select="ec2:sourceDestCheck"/>
        <xsl:apply-templates select="ec2:groupSet"/>
        <xsl:apply-templates select="ec2:tagSet" />
        <xsl:apply-templates select="ec2:license"/>
        <xsl:apply-templates select="ec2:networkInterfaceSet" />
        <xsl:apply-templates select="ec2:ebsOptimized" />
        <xsl:apply-templates select="ec2:iamInstanceProfile"/>
      </xsl:element>
    </xsl:for-each>
  </xsl:template>

  <xsl:template match="ec2:ebsOptimized">
    <xsl:element name="EbsOptimized">
      <xsl:value-of select="."/>
    </xsl:element>
  </xsl:template>
  

  <xsl:template match="ec2:iamInstanceProfile">
    <xsl:element name="InstanceProfile">
      <xsl:element name="Arn">
        <xsl:value-of select="ec2:arn"/>
      </xsl:element>
      <xsl:element name="Id">
        <xsl:value-of select="ec2:id"/>
      </xsl:element>
    </xsl:element>
  </xsl:template>

  <xsl:template match="ec2:sourceDestCheck">
    <xsl:element name="SourceDestCheck">
      <xsl:value-of select="."/>
    </xsl:element>
  </xsl:template>

  <xsl:template match="ec2:license">
    <xsl:element name="License">
      <xsl:element name="Pool">
        <xsl:value-of select="ec2:pool"/>
      </xsl:element>
    </xsl:element>
  </xsl:template>
  
  <xsl:template match="ec2:productCodes">
    <!-- output obsolete id-only list until removed from sdk -->
    <xsl:for-each select="ec2:item">
      <xsl:element name="ProductCodeId">
        <xsl:value-of select="ec2:productCode"/>
      </xsl:element>
    </xsl:for-each>
    <!-- this is the preferred output -->
    <xsl:for-each select="ec2:item">
      <xsl:element name="ProductCodes">
        <xsl:element name="ProductCodeId">
          <xsl:value-of select="ec2:productCode"/>
        </xsl:element>
        <xsl:element name="Type">
          <xsl:value-of select="ec2:type"/>
        </xsl:element>
      </xsl:element>
    </xsl:for-each>
  </xsl:template>

  <xsl:template match="ec2:instanceState">
    <xsl:element name="InstanceState">
      <xsl:element name="Code">
        <xsl:value-of select="ec2:code"/>
      </xsl:element>
      <xsl:element name="Name">
        <xsl:value-of select="ec2:name"/>
      </xsl:element>
    </xsl:element>
  </xsl:template>
  
  <xsl:template match="ec2:stateReason">
    <xsl:element name="StateReason">
      <xsl:element name="Code">
        <xsl:value-of select="ec2:code"/>
      </xsl:element>
      <xsl:element name="Message">
        <xsl:value-of select="ec2:message"/>
      </xsl:element>
    </xsl:element>
  </xsl:template>
  
  <xsl:template match="ec2:blockDeviceMapping">
    <xsl:for-each select="ec2:item">
      <xsl:element name="BlockDeviceMapping">
        <xsl:element name="DeviceName">
          <xsl:value-of select="ec2:deviceName"/>
        </xsl:element>
        <xsl:apply-templates select="ec2:ebs"/>
      </xsl:element>
    </xsl:for-each>
  </xsl:template>
  
  <xsl:template match="ec2:ebs">
    <xsl:element name="Ebs">
      <xsl:element name="VolumeId">
        <xsl:value-of select="ec2:volumeId"/>
      </xsl:element>
      <xsl:element name="Status">
        <xsl:value-of select="ec2:status"/>
      </xsl:element>
      <xsl:element name="AttachTime">
        <xsl:value-of select="ec2:attachTime"/>
      </xsl:element>
      <xsl:element name="DeleteOnTermination">
        <xsl:if test="string-length(ec2:deleteOnTermination) = 0">false</xsl:if>
        <xsl:if test="string-length(ec2:deleteOnTermination) > 0">
          <xsl:value-of select="ec2:deleteOnTermination"/>
        </xsl:if>
      </xsl:element>
    </xsl:element>
  </xsl:template>

  <xsl:template match="ec2:networkInterfaceSet">
    <xsl:for-each select="ec2:item">
      <xsl:element name="NetworkInterfaceSet">
        <xsl:element name="NetworkInterfaceId">
          <xsl:value-of select="ec2:networkInterfaceId"/>
        </xsl:element>
        <xsl:element name="SubnetId">
          <xsl:value-of select="ec2:subnetId"/>
        </xsl:element>
        <xsl:element name="VpcId">
          <xsl:value-of select="ec2:vpcId"/>
        </xsl:element>
        <xsl:element name="Description">
          <xsl:value-of select="ec2:description"/>
        </xsl:element>
        <xsl:element name="OwnerId">
          <xsl:value-of select="ec2:ownerId"/>
        </xsl:element>
        <xsl:element name="Status">
          <xsl:value-of select="ec2:status"/>
        </xsl:element>
        <xsl:element name="MacAddress">
          <xsl:value-of select="ec2:macAddress"/>
        </xsl:element>
        <xsl:element name="PrivateIpAddress">
          <xsl:value-of select="ec2:privateIpAddress"/>
        </xsl:element>
        <xsl:element name="PrivateDnsName">
          <xsl:value-of select="ec2:privateDnsName"/>
        </xsl:element>
        <xsl:apply-templates select="ec2:sourceDestCheck"/>
        <xsl:apply-templates select="ec2:groupSet"/>
        <xsl:apply-templates select="ec2:attachment"/>
        <xsl:apply-templates select="ec2:association"/>
        <xsl:apply-templates select="ec2:privateIpAddressesSet" />
      </xsl:element>
    </xsl:for-each>
  </xsl:template>

  <xsl:template match="ec2:privateIpAddressesSet">
    <xsl:for-each select="ec2:item">
      <xsl:element name="PrivateIpAddresses">
        <xsl:element name="IpAddress">
          <xsl:value-of select="ec2:privateIpAddress"/>
        </xsl:element>
        <xsl:element name="Primary">
          <xsl:value-of select="ec2:primary"/>
        </xsl:element>
        <xsl:apply-templates select="ec2:association"/>
      </xsl:element>
    </xsl:for-each>
  </xsl:template>

  <xsl:template match="ec2:attachment">
    <xsl:element name="Attachment">
      <xsl:element name="AttachmentId">
        <xsl:value-of select="ec2:attachmentId"/>
      </xsl:element>
      <xsl:element name="DeviceIndex">
        <xsl:value-of select="ec2:deviceIndex"/>
      </xsl:element>
      <xsl:element name="Status">
        <xsl:value-of select="ec2:status"/>
      </xsl:element>
      <xsl:element name="AttachTime">
        <xsl:value-of select="ec2:attachTime"/>
      </xsl:element>
      <xsl:element name="DeleteOnTermination">
        <xsl:if test="string-length(ec2:deleteOnTermination) = 0">false</xsl:if>
        <xsl:if test="string-length(ec2:deleteOnTermination) > 0">
          <xsl:value-of select="ec2:deleteOnTermination"/>
        </xsl:if>
      </xsl:element>
    </xsl:element>
  </xsl:template>

  <xsl:template match="ec2:association">
    <xsl:element name="Association">
      <xsl:element name="PublicIp">
        <xsl:value-of select="ec2:publicIp"/>
      </xsl:element>
      <xsl:element name="PublicDnsName">
        <xsl:value-of select="ec2:publicDnsName"/>
      </xsl:element>
      <xsl:element name="IpOwnerId">
        <xsl:value-of select="ec2:ipOwnerId"/>
      </xsl:element>
    </xsl:element>
  </xsl:template>

  <xsl:template match="ec2:tagSet">
    <xsl:for-each select="ec2:item">
      <xsl:element name="Tag">
        <xsl:element name="Key">
          <xsl:value-of select="ec2:key" />
        </xsl:element>
        <xsl:element name="Value">
          <xsl:value-of select="ec2:value" />
        </xsl:element>
      </xsl:element>
    </xsl:for-each>
  </xsl:template>

</xsl:stylesheet>
