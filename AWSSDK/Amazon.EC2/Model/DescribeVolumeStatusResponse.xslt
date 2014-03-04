<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
                xmlns:ec2="default-ec2-namespace"
                exclude-result-prefixes="ec2">
  <xsl:output method="xml" omit-xml-declaration="no" indent="yes"/>

  <xsl:template match="ec2:DescribeVolumeStatusResponse">
    <xsl:element name="DescribeVolumeStatusResponse">
      <xsl:element name="ResponseMetadata">
        <xsl:element name="RequestId">
          <xsl:value-of select="ec2:requestId"/>
        </xsl:element>
      </xsl:element>
      <xsl:element name="DescribeVolumeStatusResult">
        <xsl:apply-templates select="ec2:volumeStatusSet"/>
        <xsl:element name="NextToken">
          <xsl:value-of select="ec2:nextToken"/>
        </xsl:element>
      </xsl:element>
    </xsl:element>
  </xsl:template>

  <xsl:template match="ec2:volumeStatusSet">
    <xsl:for-each select="ec2:item">
      <xsl:element name="VolumeStatus">
        <xsl:element name="VolumeId">
          <xsl:value-of select="ec2:volumeId"/>
        </xsl:element>
        <xsl:element name="AvailabilityZone">
          <xsl:value-of select="ec2:availabilityZone"/>
        </xsl:element>
        <xsl:apply-templates select="ec2:volumeStatus"/>
        <xsl:apply-templates select="ec2:eventsSet" />
        <xsl:apply-templates select="ec2:actionsSet" />
      </xsl:element>
    </xsl:for-each>
  </xsl:template>

  <xsl:template match="ec2:eventsSet">
    <xsl:for-each select="ec2:item">
      <xsl:element name="VolumeStatusEvent">
        <xsl:element name="EventType">
          <xsl:value-of select="ec2:eventType"/>
        </xsl:element>
        <xsl:element name="Description">
          <xsl:value-of select="ec2:description"/>
        </xsl:element>
        <xsl:element name="NotBefore">
          <xsl:value-of select="ec2:notBefore"/>
        </xsl:element>
        <xsl:element name="NotAfter">
          <xsl:value-of select="ec2:notAfter"/>
        </xsl:element>
        <xsl:element name="EventId">
          <xsl:value-of select="ec2:eventId"/>
        </xsl:element>
      </xsl:element>
    </xsl:for-each>
  </xsl:template>

  <xsl:template match="ec2:actionsSet">
    <xsl:for-each select="ec2:item">
      <xsl:element name="VolumeStatusAction">
        <xsl:element name="Code">
          <xsl:value-of select="ec2:code"/>
        </xsl:element>
        <xsl:element name="Description">
          <xsl:value-of select="ec2:description"/>
        </xsl:element>
        <xsl:element name="EventId">
          <xsl:value-of select="ec2:eventId"/>
        </xsl:element>
        <xsl:element name="EventType">
          <xsl:value-of select="ec2:eventType"/>
        </xsl:element>
      </xsl:element>
    </xsl:for-each>
  </xsl:template>

  <xsl:template match="ec2:volumeStatus">
    <xsl:element name="VolumeStatusInfo">
      <xsl:element name="Status">
        <xsl:value-of select="ec2:status"/>
      </xsl:element>
      <xsl:apply-templates select="ec2:details" />
    </xsl:element>
  </xsl:template>

  <xsl:template match="ec2:details">
    <xsl:for-each select="ec2:item">
      <xsl:element name="VolumeStatusDetail">
        <xsl:element name="Name">
          <xsl:value-of select="ec2:name"/>
        </xsl:element>
        <xsl:element name="Status">
          <xsl:value-of select="ec2:status"/>
        </xsl:element>
      </xsl:element>
    </xsl:for-each>
  </xsl:template>
  
</xsl:stylesheet>

