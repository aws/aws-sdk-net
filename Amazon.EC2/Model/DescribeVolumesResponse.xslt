<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform" xmlns:ec2="default-ec2-namespace" exclude-result-prefixes="ec2">
  <xsl:output method="xml" omit-xml-declaration="no" indent="yes"/>
  <xsl:template match="ec2:DescribeVolumesResponse">
    <xsl:element name="DescribeVolumesResponse">
      <xsl:element name="ResponseMetadata">
        <xsl:element name="RequestId">
          <xsl:value-of select="ec2:requestId"/>
        </xsl:element>
      </xsl:element>
      <xsl:element name="DescribeVolumesResult">
        <xsl:apply-templates select="ec2:volumeSet"/>
      </xsl:element>
    </xsl:element>
  </xsl:template>
  <xsl:template match="ec2:volumeSet">
    <xsl:for-each select="ec2:item">
      <xsl:element name="Volume">
        <xsl:element name="VolumeId">
          <xsl:value-of select="ec2:volumeId"/>
        </xsl:element>
        <xsl:element name="Size">
          <xsl:value-of select="ec2:size"/>
        </xsl:element>
        <xsl:element name="SnapshotId">
          <xsl:value-of select="ec2:snapshotId"/>
        </xsl:element>
        <xsl:element name="AvailabilityZone">
          <xsl:value-of select="ec2:availabilityZone"/>
        </xsl:element>
        <xsl:element name="Status">
          <xsl:value-of select="ec2:status"/>
        </xsl:element>
        <xsl:element name="CreateTime">
          <xsl:value-of select="ec2:createTime"/>
        </xsl:element>
        <xsl:element name="IOPS">
          <xsl:value-of select="ec2:iops"/>
        </xsl:element>
        <xsl:element name="VolumeType">
          <xsl:value-of select="ec2:volumeType"/>
        </xsl:element>
        <xsl:apply-templates select="ec2:attachmentSet"/>
        <xsl:apply-templates select="ec2:tagSet" />
      </xsl:element>
    </xsl:for-each>
  </xsl:template>
  <xsl:template match="ec2:attachmentSet">
    <xsl:for-each select="ec2:item">
      <xsl:element name="Attachment">
        <xsl:element name="VolumeId">
          <xsl:value-of select="ec2:volumeId"/>
        </xsl:element>
        <xsl:element name="InstanceId">
          <xsl:value-of select="ec2:instanceId"/>
        </xsl:element>
        <xsl:element name="Device">
          <xsl:value-of select="ec2:device"/>
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
    </xsl:for-each>
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
