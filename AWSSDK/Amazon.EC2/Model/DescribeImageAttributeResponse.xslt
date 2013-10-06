<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform" xmlns:ec2="default-ec2-namespace" exclude-result-prefixes="ec2">
  <xsl:output method="xml" omit-xml-declaration="no" indent="yes"/>
  <xsl:template match="ec2:DescribeImageAttributeResponse">
    <xsl:element name="DescribeImageAttributeResponse">
      <xsl:element name="ResponseMetadata">
        <xsl:element name="RequestId">
          <xsl:value-of select="ec2:requestId"/>
        </xsl:element>
      </xsl:element>
      <xsl:element name="DescribeImageAttributeResult">
        <xsl:element name="ImageAttribute">
          <xsl:element name="ImageId">
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
      <xsl:element name="LaunchPermission">
        <xsl:element name="UserId">
          <xsl:value-of select="ec2:userId"/>
        </xsl:element>
        <xsl:element name="GroupName">
          <xsl:value-of select="ec2:group"/>
        </xsl:element>
      </xsl:element>
    </xsl:for-each>
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
  <xsl:template match="ec2:description">
    <xsl:element name="Description">
      <xsl:value-of select="ec2:value"/>
    </xsl:element>
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
        <xsl:apply-templates select="ec2:noDevice"/>
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
    <xsl:element name="NoDevice">
      <xsl:value-of select="'true'"/>
    </xsl:element>
  </xsl:template>
</xsl:stylesheet>