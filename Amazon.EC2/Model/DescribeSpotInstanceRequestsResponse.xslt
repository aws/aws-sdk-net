<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet version="1.0"
  xmlns:xsl="http://www.w3.org/1999/XSL/Transform" xmlns:ec2="http://ec2.amazonaws.com/doc/2009-11-30/"
  exclude-result-prefixes="ec2">
  <xsl:output method="xml" omit-xml-declaration="no" indent="yes" />
  <xsl:variable name="ns"
    select="'http://ec2.amazonaws.com/doc/2009-11-30/'" />
  <xsl:template match="ec2:DescribeSpotInstanceRequestsResponse">
    <xsl:element name="DescribeSpotInstanceRequestsResponse" namespace="{$ns}">
      <xsl:element name="ResponseMetadata" namespace="{$ns}">
        <xsl:element name="RequestId" namespace="{$ns}">
          <xsl:value-of select="ec2:requestId" />
        </xsl:element>
      </xsl:element>
      <xsl:element name="DescribeSpotInstanceRequestsResult" namespace="{$ns}">
        <xsl:apply-templates select="ec2:spotInstanceRequestSet"/>
      </xsl:element>
    </xsl:element>
  </xsl:template>
  <xsl:template match="ec2:spotInstanceRequestSet">
    <xsl:for-each select="ec2:item">
      <xsl:element name="SpotInstanceRequest" namespace="{$ns}">
        <xsl:element name="SpotInstanceRequestId" namespace="{$ns}">
          <xsl:value-of select="ec2:spotInstanceRequestId"/>
        </xsl:element>
        <xsl:element name="SpotPrice" namespace="{$ns}">
          <xsl:value-of select="ec2:spotPrice"/>
        </xsl:element>
        <xsl:element name="Type" namespace="{$ns}">
          <xsl:value-of select="ec2:type"/>
        </xsl:element>
        <xsl:element name="State" namespace="{$ns}">
          <xsl:value-of select="ec2:state"/>
        </xsl:element>
        <xsl:apply-templates select="ec2:fault"/>
        <xsl:element name="ValidFrom" namespace="{$ns}">
          <xsl:value-of select="ec2:validFrom"/>
        </xsl:element>
        <xsl:element name="ValidUntil" namespace="{$ns}">
          <xsl:value-of select="ec2:validUntil"/>
        </xsl:element>
        <xsl:element name="LaunchGroup" namespace="{$ns}">
          <xsl:value-of select="ec2:launchGroup"/>
        </xsl:element>
        <xsl:element name="AvailabilityZoneGroup" namespace="{$ns}">
          <xsl:value-of select="ec2:availabilityZoneGroup"/>
        </xsl:element>
        <xsl:apply-templates select="ec2:launchSpecification"/>
        <xsl:element name="InstanceId" namespace="{$ns}">
          <xsl:value-of select="ec2:instanceId"/>
        </xsl:element>
        <xsl:element name="CreateTime" namespace="{$ns}">
          <xsl:value-of select="ec2:createTime"/>
        </xsl:element>
        <xsl:element name="ProductDescription" namespace="{$ns}">
          <xsl:value-of select="ec2:productDescription"/>
        </xsl:element>
      </xsl:element>
    </xsl:for-each>
  </xsl:template>
  <xsl:template match="ec2:fault">
    <xsl:element name="Fault" namespace="{$ns}">
      <xsl:element name="Code" namespace="{$ns}">
        <xsl:value-of select="ec2:code" />
      </xsl:element>
      <xsl:element name="Message" namespace="{$ns}">
        <xsl:value-of select="ec2:message" />
      </xsl:element>
    </xsl:element>
  </xsl:template>
  <xsl:template match="ec2:launchSpecification">
    <xsl:element name="LaunchSpecification" namespace="{$ns}">
      <xsl:element name="ImageId" namespace="{$ns}">
        <xsl:value-of select="ec2:imageId"/>
      </xsl:element>
      <xsl:element name="KeyName" namespace="{$ns}">
        <xsl:value-of select="ec2:keyName"/>
      </xsl:element>
      <xsl:apply-templates select="ec2:groupSet"/>
      <xsl:element name="AddressingType" namespace="{$ns}">
        <xsl:value-of select="ec2:addressingType"/>
      </xsl:element>
      <xsl:element name="InstanceType" namespace="{$ns}">
        <xsl:value-of select="ec2:instanceType"/>
      </xsl:element>
      <xsl:element name="Placement" namespace="{$ns}">
        <xsl:element name="AvailabilityZone" namespace="{$ns}">
          <xsl:value-of select="ec2:placement/ec2:availabilityZone"/>
        </xsl:element>
      </xsl:element>
      <xsl:element name="KernelId" namespace="{$ns}">
        <xsl:value-of select="ec2:kernelId"/>
      </xsl:element>
      <xsl:element name="RamdiskId" namespace="{$ns}">
        <xsl:value-of select="ec2:ramdiskId"/>
      </xsl:element>
      <xsl:apply-templates select="ec2:blockDeviceMapping"/>
      <xsl:element name="Monitoring" namespace="{$ns}">
        <xsl:element name="Enabled" namespace="{$ns}">
          <xsl:value-of select="ec2:monitoring/ec2:enabled"/>
        </xsl:element>
      </xsl:element>
      <xsl:element name="SubnetId" namespace="{$ns}">
        <xsl:value-of select="ec2:subnetId"/>
      </xsl:element>
    </xsl:element>
  </xsl:template>
  <xsl:template match="ec2:groupSet">
    <xsl:for-each select="ec2:item">
      <xsl:element name="SecurityGroup" namespace="{$ns}">
        <xsl:value-of select="ec2:groupId"/>
      </xsl:element>
    </xsl:for-each>
  </xsl:template>
  <xsl:template match="ec2:blockDeviceMapping">
    <xsl:for-each select="ec2:item">
      <xsl:element name="BlockDeviceMapping" namespace="{$ns}">
        <xsl:element name="DeviceName" namespace="{$ns}">
          <xsl:value-of select="ec2:deviceName"/>
        </xsl:element>
        <xsl:apply-templates select="ec2:ebs"/>
      </xsl:element>
    </xsl:for-each>
  </xsl:template>
  <xsl:template match="ec2:ebs">
    <xsl:element name="Ebs" namespace="{$ns}">
      <xsl:element name="VolumeId" namespace="{$ns}">
        <xsl:value-of select="ec2:volumeId"/>
      </xsl:element>
      <xsl:element name="Status" namespace="{$ns}">
        <xsl:value-of select="ec2:status"/>
      </xsl:element>
      <xsl:element name="AttachTime" namespace="{$ns}">
        <xsl:value-of select="ec2:attachTime"/>
      </xsl:element>
      <xsl:element name="DeleteOnTermination" namespace="{$ns}">
        <xsl:if test="string-length(ec2:deleteOnTermination) = 0">false</xsl:if>
        <xsl:if test="string-length(ec2:deleteOnTermination) > 0">
          <xsl:value-of select="ec2:deleteOnTermination"/>
        </xsl:if>
      </xsl:element>
    </xsl:element>
  </xsl:template>
</xsl:stylesheet>
