<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform" xmlns:ec2="http://ec2.amazonaws.com/doc/2009-11-30/" exclude-result-prefixes="ec2">
  <xsl:output method="xml" omit-xml-declaration="no" indent="yes"/>
  <xsl:variable name="ns" select="'http://ec2.amazonaws.com/doc/2009-11-30/'"/>
  <xsl:template match="ec2:DescribeImageAttributeResponse">
    <xsl:element name="DescribeImageAttributeResponse" namespace="{$ns}">
      <xsl:element name="ResponseMetadata" namespace="{$ns}">
        <xsl:element name="RequestId" namespace="{$ns}">
          <xsl:value-of select="ec2:requestId"/>
        </xsl:element>
      </xsl:element>
      <xsl:element name="DescribeImageAttributeResult" namespace="{$ns}">
        <xsl:element name="ImageAttribute" namespace="{$ns}">
          <xsl:element name="ImageId" namespace="{$ns}">
            <xsl:value-of select="ec2:imageId"/>
          </xsl:element>
          <xsl:apply-templates select="ec2:launchPermission"/>
          <xsl:apply-templates select="ec2:productCodes"/>
          <xsl:apply-templates select="ec2:kernel"/>
          <xsl:apply-templates select="ec2:ramdisk"/>
          <xsl:apply-templates select="ec2:description"/>
          <xsl:apply-templates select="ec2:blockDeviceMapping"/>
        </xsl:element>
      </xsl:element>
    </xsl:element>
  </xsl:template>
  <xsl:template match="ec2:launchPermission">
    <xsl:for-each select="ec2:item">
      <xsl:element name="LaunchPermission" namespace="{$ns}">
        <xsl:element name="UserId" namespace="{$ns}">
          <xsl:value-of select="ec2:userId"/>
        </xsl:element>
        <xsl:element name="GroupName" namespace="{$ns}">
          <xsl:value-of select="ec2:group"/>
        </xsl:element>
      </xsl:element>
    </xsl:for-each>
  </xsl:template>
  <xsl:template match="ec2:productCodes">
    <xsl:for-each select="ec2:item">
      <xsl:element name="ProductCode" namespace="{$ns}">
        <xsl:value-of select="ec2:productCode"/>
      </xsl:element>
    </xsl:for-each>
  </xsl:template>
  <xsl:template match="ec2:kernel">
    <xsl:element name="KernelId" namespace="{$ns}">
      <xsl:value-of select="ec2:value"/>
    </xsl:element>
  </xsl:template>
  <xsl:template match="ec2:ramdisk">
    <xsl:element name="RamdiskId" namespace="{$ns}">
      <xsl:value-of select="ec2:value"/>
    </xsl:element>
  </xsl:template>
  <xsl:template match="ec2:description">
    <xsl:element name="Description" namespace="{$ns}">
      <xsl:value-of select="ec2:value"/>
    </xsl:element>
  </xsl:template>
  <xsl:template match="ec2:blockDeviceMapping">
    <xsl:for-each select="ec2:item">
      <xsl:element name="BlockDeviceMapping" namespace="{$ns}">
        <xsl:element name="DeviceName" namespace="{$ns}">
          <xsl:value-of select="ec2:deviceName"/>
        </xsl:element>
        <xsl:element name="VirtualName" namespace="{$ns}">
          <xsl:value-of select="ec2:virtualName"/>
        </xsl:element>
        <xsl:apply-templates select="ec2:ebs"/>
        <xsl:apply-templates select="ec2:noDevice"/>
      </xsl:element>
    </xsl:for-each>
  </xsl:template>
  <xsl:template match="ec2:ebs">
    <xsl:element name="Ebs" namespace="{$ns}">
      <xsl:element name="SnapshotId" namespace="{$ns}">
        <xsl:value-of select="ec2:snapshotId"/>
      </xsl:element>
      <!-- if a snapshot is specified, the volumeSize is optional -->
      <xsl:if test="ec2:volumeSize">
        <xsl:element name="VolumeSize" namespace="{$ns}">
          <xsl:value-of select="ec2:volumeSize"/>
        </xsl:element>
      </xsl:if>
      <xsl:element name="DeleteOnTermination" namespace="{$ns}">
        <xsl:if test="string-length(ec2:deleteOnTermination) = 0">
          <xsl:text>false</xsl:text>
        </xsl:if>
        <xsl:if test="string-length(ec2:deleteOnTermination) > 0">
          <xsl:value-of select="ec2:deleteOnTermination"/>
        </xsl:if>
      </xsl:element>
    </xsl:element>
  </xsl:template>
  <xsl:template match="ec2:noDevice">
    <xsl:element name="NoDevice" namespace="{$ns}">
      <xsl:value-of select="'true'"/>
    </xsl:element>
  </xsl:template>
</xsl:stylesheet>