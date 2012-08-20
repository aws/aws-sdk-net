<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform" xmlns:ec2="default-ec2-namespace" exclude-result-prefixes="ec2">
  <xsl:output method="xml" omit-xml-declaration="no" indent="yes"/>
  <xsl:template match="ec2:DescribeInstanceAttributeResponse">
    <xsl:element name="DescribeInstanceAttributeResponse">
      <xsl:element name="ResponseMetadata">
        <xsl:element name="RequestId">
          <xsl:value-of select="ec2:requestId"/>
        </xsl:element>
      </xsl:element>
      <xsl:element name="DescribeInstanceAttributeResult">
        <xsl:element name="InstanceAttribute">
          <xsl:element name="InstanceId">
            <xsl:value-of select="ec2:instanceId"/>
          </xsl:element>
          <xsl:apply-templates select="ec2:instanceType"/>
          <xsl:apply-templates select="ec2:kernel"/>
          <xsl:apply-templates select="ec2:ramdisk"/>
          <xsl:apply-templates select="ec2:userData"/>
          <xsl:apply-templates select="ec2:disableApiTermination"/>
          <xsl:apply-templates select="ec2:instanceInitiatedShutdownBehavior"/>
          <xsl:apply-templates select="ec2:rootDeviceName"/>
          <xsl:apply-templates select="ec2:blockDeviceMapping"/>
          <xsl:apply-templates select="ec2:sourceDestCheck"/>
          <xsl:apply-templates select="ec2:groupSet"/>
          <xsl:apply-templates select="ec2:productCodes"/>
          <xsl:apply-templates select="ec2:ebsOptimized"/>
        </xsl:element>
      </xsl:element>
    </xsl:element>
  </xsl:template>

  <xsl:template match="ec2:sourceDestCheck">
    <xsl:element name="SourceDestCheck">
      <xsl:value-of select="."/>
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

  <xsl:template match="ec2:instanceType">
    <xsl:element name="InstanceType">
      <xsl:value-of select="ec2:value"/>
    </xsl:element>
  </xsl:template>
  <xsl:template match="ec2:kernel">
    <xsl:element name="KernelId">
      <xsl:value-of select="ec2:value"/>
    </xsl:element>
  </xsl:template>
  <xsl:template match="ec2:ramdisk">
    <xsl:element name="RamdiskId">
      <xsl:value-of select="ec2:value"/>
    </xsl:element>
  </xsl:template>
  <xsl:template match="ec2:userData">
    <xsl:element name="UserData">
      <xsl:value-of select="ec2:value"/>
    </xsl:element>
  </xsl:template>
  <xsl:template match="ec2:disableApiTermination">
    <xsl:element name="DisableApiTermination">
      <xsl:value-of select="ec2:value"/>
    </xsl:element>
  </xsl:template>
  <xsl:template match="ec2:instanceInitiatedShutdownBehavior">
    <xsl:element name="InstanceInitiatedShutdownBehavior">
      <xsl:value-of select="ec2:value"/>
    </xsl:element>
  </xsl:template>
  <xsl:template match="ec2:rootDeviceName">
    <xsl:element name="RootDeviceName">
      <xsl:value-of select="ec2:value"/>
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
  <xsl:template match="ec2:productCodes">
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
  <xsl:template match="ec2:ebsOptimized">
    <xsl:element name="EbsOptimized">
      <xsl:value-of select="ec2:value"/>
    </xsl:element>
  </xsl:template>
</xsl:stylesheet>
