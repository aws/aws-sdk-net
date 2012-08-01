<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet version="1.0"
  xmlns:xsl="http://www.w3.org/1999/XSL/Transform" xmlns:ec2="default-ec2-namespace"
  exclude-result-prefixes="ec2">
  <xsl:output method="xml" omit-xml-declaration="no" indent="yes" />
  <xsl:template match="ec2:DescribeSpotInstanceRequestsResponse">
    <xsl:element name="DescribeSpotInstanceRequestsResponse">
      <xsl:element name="ResponseMetadata">
        <xsl:element name="RequestId">
          <xsl:value-of select="ec2:requestId" />
        </xsl:element>
      </xsl:element>
      <xsl:element name="DescribeSpotInstanceRequestsResult">
        <xsl:apply-templates select="ec2:spotInstanceRequestSet"/>
      </xsl:element>
    </xsl:element>
  </xsl:template>

  <xsl:template match="ec2:spotInstanceRequestSet">
    <xsl:for-each select="ec2:item">
      <xsl:element name="SpotInstanceRequest">
        <xsl:element name="SpotInstanceRequestId">
          <xsl:value-of select="ec2:spotInstanceRequestId"/>
        </xsl:element>
        <xsl:element name="SpotPrice">
          <xsl:value-of select="ec2:spotPrice"/>
        </xsl:element>
        <xsl:element name="Type">
          <xsl:value-of select="ec2:type"/>
        </xsl:element>
        <xsl:element name="State">
          <xsl:value-of select="ec2:state"/>
        </xsl:element>
        <xsl:apply-templates select="ec2:fault"/>
        <xsl:element name="ValidFrom">
          <xsl:value-of select="ec2:validFrom"/>
        </xsl:element>
        <xsl:element name="ValidUntil">
          <xsl:value-of select="ec2:validUntil"/>
        </xsl:element>
        <xsl:element name="LaunchGroup">
          <xsl:value-of select="ec2:launchGroup"/>
        </xsl:element>
        <xsl:element name="AvailabilityZoneGroup">
          <xsl:value-of select="ec2:availabilityZoneGroup"/>
        </xsl:element>
        <xsl:apply-templates select="ec2:launchSpecification"/>
        <xsl:element name="InstanceId">
          <xsl:value-of select="ec2:instanceId"/>
        </xsl:element>
        <xsl:element name="CreateTime">
          <xsl:value-of select="ec2:createTime"/>
        </xsl:element>
        <xsl:element name="ProductDescription">
          <xsl:value-of select="ec2:productDescription"/>
        </xsl:element>
        <xsl:apply-templates select="ec2:tagSet" />
        <xsl:element name="LaunchedAvailabilityZone">
          <xsl:value-of select="ec2:launchedAvailabilityZone"/>
        </xsl:element>
      </xsl:element>
    </xsl:for-each>
  </xsl:template>

  <xsl:template match="ec2:fault">
    <xsl:element name="Fault">
      <xsl:element name="Code">
        <xsl:value-of select="ec2:code" />
      </xsl:element>
      <xsl:element name="Message">
        <xsl:value-of select="ec2:message" />
      </xsl:element>
    </xsl:element>
  </xsl:template>

  <xsl:template match="ec2:launchSpecification">
    <xsl:element name="LaunchSpecification">
      <xsl:element name="ImageId">
        <xsl:value-of select="ec2:imageId"/>
      </xsl:element>
      <xsl:element name="KeyName">
        <xsl:value-of select="ec2:keyName"/>
      </xsl:element>
      <xsl:apply-templates select="ec2:groupSet" mode="idAndName"/>
      <xsl:element name="AddressingType">
        <xsl:value-of select="ec2:addressingType"/>
      </xsl:element>
      <xsl:element name="InstanceType">
        <xsl:value-of select="ec2:instanceType"/>
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
      <xsl:apply-templates select="ec2:blockDeviceMapping"/>
      <xsl:element name="Monitoring">
        <xsl:element name="Enabled">
          <xsl:value-of select="ec2:monitoring/ec2:enabled"/>
        </xsl:element>
      </xsl:element>
      <xsl:element name="SubnetId">
        <xsl:value-of select="ec2:subnetId"/>
      </xsl:element>
      <xsl:apply-templates select="ec2:networkInterfaceSet" />
    </xsl:element>
  </xsl:template>

  <xsl:template match="ec2:groupSet" mode="idAndName">
    <xsl:for-each select="ec2:item">
      <xsl:element name="SecurityGroup">
        <xsl:value-of select="ec2:groupName"/>
      </xsl:element>
      <xsl:element name="SecurityGroupId">
        <xsl:value-of select="ec2:groupId"/>
      </xsl:element>
    </xsl:for-each>
  </xsl:template>

  <xsl:template match="ec2:groupSet" mode="idOnly">
    <xsl:for-each select="ec2:item">
      <xsl:element name="GroupId">
        <xsl:value-of select="ec2:groupId"/>
      </xsl:element>
    </xsl:for-each>
  </xsl:template>

  <xsl:template match="ec2:blockDeviceMapping">
    <xsl:for-each select="ec2:item">
      <xsl:element name="BlockDeviceMapping">
        <xsl:element name="DeviceName">
          <xsl:value-of select="ec2:deviceName"/>
        </xsl:element>
        <xsl:element name="VirtualName">
          <xsl:value-of select="ec2:virtualName"/>
        </xsl:element>
        <xsl:apply-templates select="ec2:ebs"/>
        <xsl:element name="NoDevice">
          <xsl:value-of select="ec2:noDevice"/>
        </xsl:element>
      </xsl:element>
    </xsl:for-each>
  </xsl:template>
  <xsl:template match="ec2:ebs">
    <xsl:element name="Ebs">
      <xsl:element name="SnapshotId">
        <xsl:value-of select="ec2:snapshotId"/>
      </xsl:element>
      <!-- if a snapshot is specified, the volumeSize is optional -->
      <xsl:if test="ec2:volumeSize">
        <xsl:element name="VolumeSize">
          <xsl:value-of select="ec2:volumeSize"/>
        </xsl:element>
      </xsl:if>
      <xsl:element name="DeleteOnTermination">
        <xsl:if test="string-length(ec2:deleteOnTermination) = 0">false</xsl:if>
        <xsl:if test="string-length(ec2:deleteOnTermination) > 0">
          <xsl:value-of select="ec2:deleteOnTermination"/>
        </xsl:if>
      </xsl:element>
      <xsl:if test="ec2:volumeType">
        <xsl:element name="VolumeType">
          <xsl:value-of select="ec2:volumeType"/>
        </xsl:element>
      </xsl:if>
      <xsl:if test="ec2:iops">
        <xsl:element name="IOPS">
          <xsl:value-of select="ec2:iops"/>
        </xsl:element>
      </xsl:if>
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

  <xsl:template match="ec2:networkInterfaceSet">
    <xsl:for-each select="ec2:item">
      <xsl:element name="InstanceNetworkInterfaceSpecification">
        <xsl:element name="NetworkInterfaceId">
          <xsl:value-of select="ec2:networkInterfaceId"/>
        </xsl:element>
        <xsl:element name="DeviceIndex">
          <xsl:value-of select="ec2:deviceIndex"/>
        </xsl:element>
        <xsl:element name="SubnetId">
          <xsl:value-of select="ec2:subnetId"/>
        </xsl:element>
        <xsl:element name="Description">
          <xsl:value-of select="ec2:description"/>
        </xsl:element>
        <xsl:element name="PrivateIpAddress">
          <xsl:value-of select="ec2:privateIpAddress"/>
        </xsl:element>
        <xsl:apply-templates select="ec2:groupSet" mode="idOnly"/>
        <xsl:element name="DeleteOnTermination">
          <xsl:if test="string-length(ec2:deleteOnTermination) = 0">false</xsl:if>
          <xsl:if test="string-length(ec2:deleteOnTermination) > 0">
            <xsl:value-of select="ec2:deleteOnTermination"/>
          </xsl:if>
        </xsl:element>
      </xsl:element>
    </xsl:for-each>
  </xsl:template>
</xsl:stylesheet>
