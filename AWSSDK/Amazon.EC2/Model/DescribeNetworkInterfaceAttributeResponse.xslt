<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform" xmlns:ec2="default-ec2-namespace" exclude-result-prefixes="ec2">
  <xsl:output method="xml" omit-xml-declaration="no" indent="yes"/>

  <xsl:template match="ec2:DescribeNetworkInterfaceAttributeResponse">
    <xsl:element name="DescribeNetworkInterfaceAttributeResponse">
      <xsl:element name="ResponseMetadata">
        <xsl:element name="RequestId">
          <xsl:value-of select="ec2:requestId"/>
        </xsl:element>
      </xsl:element>
      <xsl:element name="DescribeNetworkInterfaceAttributeResult">
        <xsl:element name="NetworkInterfaceAttribute">
          <xsl:element name="NetworkInterfaceId">
            <xsl:value-of select="ec2:networkInterfaceId"/>
          </xsl:element>
          <xsl:element name="Description">
            <xsl:value-of select="ec2:description"/>
          </xsl:element>
          <xsl:apply-templates select="ec2:sourceDestCheck"/>
          <xsl:apply-templates select="ec2:groupSet"/>
          <xsl:apply-templates select="ec2:attachment"/>
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
      <xsl:element name="GroupId">
        <xsl:value-of select="ec2:groupId"/>
      </xsl:element>
      <xsl:element name="GroupName">
        <xsl:value-of select="ec2:groupName"/>
      </xsl:element>
    </xsl:for-each>
  </xsl:template>

  <xsl:template match="ec2:attachment">
    <xsl:element name="Attachment">
      <xsl:element name="AttachmentId">
        <xsl:value-of select="ec2:attachmentId"/>
      </xsl:element>
      <xsl:element name="InstanceId">
        <xsl:value-of select="ec2:instanceId"/>
      </xsl:element>
      <xsl:element name="InstanceOwnerId">
        <xsl:value-of select="ec2:instanceOwnerId"/>
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

</xsl:stylesheet>

