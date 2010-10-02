<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform" xmlns:ec2="http://ec2.amazonaws.com/doc/2010-08-31/" exclude-result-prefixes="ec2">
  <xsl:output method="xml" omit-xml-declaration="no" indent="yes"/>
  <xsl:variable name="ns" select="'http://ec2.amazonaws.com/doc/2010-08-31/'"/>
  <xsl:template match="ec2:DescribeVolumesResponse">
    <xsl:element name="DescribeVolumesResponse" namespace="{$ns}">
      <xsl:element name="ResponseMetadata" namespace="{$ns}">
        <xsl:element name="RequestId" namespace="{$ns}">
          <xsl:value-of select="ec2:requestId"/>
        </xsl:element>
      </xsl:element>
      <xsl:element name="DescribeVolumesResult" namespace="{$ns}">
        <xsl:apply-templates select="ec2:volumeSet"/>
      </xsl:element>
    </xsl:element>
  </xsl:template>
  <xsl:template match="ec2:volumeSet">
    <xsl:for-each select="ec2:item">
      <xsl:element name="Volume" namespace="{$ns}">
        <xsl:element name="VolumeId" namespace="{$ns}">
          <xsl:value-of select="ec2:volumeId"/>
        </xsl:element>
        <xsl:element name="Size" namespace="{$ns}">
          <xsl:value-of select="ec2:size"/>
        </xsl:element>
        <xsl:element name="SnapshotId" namespace="{$ns}">
          <xsl:value-of select="ec2:snapshotId"/>
        </xsl:element>
        <xsl:element name="AvailabilityZone" namespace="{$ns}">
          <xsl:value-of select="ec2:availabilityZone"/>
        </xsl:element>
        <xsl:element name="Status" namespace="{$ns}">
          <xsl:value-of select="ec2:status"/>
        </xsl:element>
        <xsl:element name="CreateTime" namespace="{$ns}">
          <xsl:value-of select="ec2:createTime"/>
        </xsl:element>
        <xsl:apply-templates select="ec2:attachmentSet"/>
        <xsl:apply-templates select="ec2:tagSet" />
      </xsl:element>
    </xsl:for-each>
  </xsl:template>
  <xsl:template match="ec2:attachmentSet">
    <xsl:for-each select="ec2:item">
      <xsl:element name="Attachment" namespace="{$ns}">
        <xsl:element name="VolumeId" namespace="{$ns}">
          <xsl:value-of select="ec2:volumeId"/>
        </xsl:element>
        <xsl:element name="InstanceId" namespace="{$ns}">
          <xsl:value-of select="ec2:instanceId"/>
        </xsl:element>
        <xsl:element name="Device" namespace="{$ns}">
          <xsl:value-of select="ec2:device"/>
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
    </xsl:for-each>
  </xsl:template>
  <xsl:template match="ec2:tagSet">
    <xsl:for-each select="ec2:item">
      <xsl:element name="Tag" namespace="{$ns}">
        <xsl:element name="Key" namespace="{$ns}">
          <xsl:value-of select="ec2:key" />
        </xsl:element>
        <xsl:element name="Value" namespace="{$ns}">
          <xsl:value-of select="ec2:value" />
        </xsl:element>
      </xsl:element>
    </xsl:for-each>
  </xsl:template>
</xsl:stylesheet>
