<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
                xmlns:ec2="http://ec2.amazonaws.com/doc/2012-06-15/"
                exclude-result-prefixes="ec2">
  <xsl:output method="xml" omit-xml-declaration="no" indent="yes"/>
  <xsl:variable name="ns" select="'http://ec2.amazonaws.com/doc/2012-06-15/'"/>

  <xsl:template match="ec2:DescribeVolumeStatusResponse">
    <xsl:element name="DescribeVolumeStatusResponse" namespace="{$ns}">
      <xsl:element name="ResponseMetadata" namespace="{$ns}">
        <xsl:element name="RequestId" namespace="{$ns}">
          <xsl:value-of select="ec2:requestId"/>
        </xsl:element>
      </xsl:element>
      <xsl:element name="DescribeVolumeStatusResult" namespace="{$ns}">
        <xsl:apply-templates select="ec2:volumeStatusSet"/>
        <xsl:element name="NextToken" namespace="{$ns}">
          <xsl:value-of select="ec2:nextToken"/>
        </xsl:element>
      </xsl:element>
    </xsl:element>
  </xsl:template>

  <xsl:template match="ec2:volumeStatusSet">
    <xsl:for-each select="ec2:item">
      <xsl:element name="VolumeStatus" namespace="{$ns}">
        <xsl:element name="VolumeId" namespace="{$ns}">
          <xsl:value-of select="ec2:volumeId"/>
        </xsl:element>
        <xsl:element name="AvailabilityZone" namespace="{$ns}">
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
      <xsl:element name="VolumeStatusEvent" namespace="{$ns}">
        <xsl:element name="EventType" namespace="{$ns}">
          <xsl:value-of select="ec2:eventType"/>
        </xsl:element>
        <xsl:element name="Description" namespace="{$ns}">
          <xsl:value-of select="ec2:description"/>
        </xsl:element>
        <xsl:element name="NotBefore" namespace="{$ns}">
          <xsl:value-of select="ec2:notBefore"/>
        </xsl:element>
        <xsl:element name="NotAfter" namespace="{$ns}">
          <xsl:value-of select="ec2:notAfter"/>
        </xsl:element>
        <xsl:element name="EventId" namespace="{$ns}">
          <xsl:value-of select="ec2:eventId"/>
        </xsl:element>
      </xsl:element>
    </xsl:for-each>
  </xsl:template>

  <xsl:template match="ec2:actionsSet">
    <xsl:for-each select="ec2:item">
      <xsl:element name="VolumeStatusAction" namespace="{$ns}">
        <xsl:element name="Code" namespace="{$ns}">
          <xsl:value-of select="ec2:code"/>
        </xsl:element>
        <xsl:element name="Description" namespace="{$ns}">
          <xsl:value-of select="ec2:description"/>
        </xsl:element>
        <xsl:element name="EventId" namespace="{$ns}">
          <xsl:value-of select="ec2:eventId"/>
        </xsl:element>
        <xsl:element name="EventType" namespace="{$ns}">
          <xsl:value-of select="ec2:eventType"/>
        </xsl:element>
      </xsl:element>
    </xsl:for-each>
  </xsl:template>

  <xsl:template match="ec2:volumeStatus">
    <xsl:element name="VolumeStatusInfo" namespace="{$ns}">
      <xsl:element name="Status" namespace="{$ns}">
        <xsl:value-of select="ec2:status"/>
      </xsl:element>
      <xsl:apply-templates select="ec2:details" />
    </xsl:element>
  </xsl:template>

  <xsl:template match="ec2:details">
    <xsl:for-each select="ec2:item">
      <xsl:element name="VolumeStatusDetail" namespace="{$ns}">
        <xsl:element name="Name" namespace="{$ns}">
          <xsl:value-of select="ec2:name"/>
        </xsl:element>
        <xsl:element name="Status" namespace="{$ns}">
          <xsl:value-of select="ec2:status"/>
        </xsl:element>
      </xsl:element>
    </xsl:for-each>
  </xsl:template>
  
</xsl:stylesheet>

