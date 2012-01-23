<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
                xmlns:ec2="http://ec2.amazonaws.com/doc/2011-11-01/"
                exclude-result-prefixes="ec2">
  <xsl:output method="xml" omit-xml-declaration="no" indent="yes"/>
  <xsl:variable name="ns" select="'http://ec2.amazonaws.com/doc/2011-11-01/'"/>

  <xsl:template match="ec2:DescribeInstanceStatusResponse">
    <xsl:element name="DescribeInstanceStatusResponse" namespace="{$ns}">
      <xsl:element name="ResponseMetadata" namespace="{$ns}">
        <xsl:element name="RequestId" namespace="{$ns}">
          <xsl:value-of select="ec2:requestId"/>
        </xsl:element>
      </xsl:element>
      <xsl:element name="DescribeInstanceStatusResult" namespace="{$ns}">
        <xsl:apply-templates select="ec2:instanceStatusSet"/>
        <xsl:element name="NextToken" namespace="{$ns}">
          <xsl:value-of select="ec2:nextToken"/>
        </xsl:element>
      </xsl:element>
    </xsl:element>
  </xsl:template>

  <xsl:template match="ec2:instanceStatusSet">
    <xsl:for-each select="ec2:item">
      <xsl:element name="InstanceStatus" namespace="{$ns}">
        <xsl:element name="InstanceId" namespace="{$ns}">
          <xsl:value-of select="ec2:instanceId"/>
        </xsl:element>
        <xsl:element name="AvailabilityZone" namespace="{$ns}">
          <xsl:value-of select="ec2:availabilityZone"/>
        </xsl:element>
        <xsl:apply-templates select="ec2:eventsSet" />
        <xsl:apply-templates select="ec2:instanceState"/>
      </xsl:element>
    </xsl:for-each>
  </xsl:template>

  <xsl:template match="ec2:eventsSet">
    <xsl:for-each select="ec2:item">
      <xsl:element name="InstanceStatusEvent" namespace="{$ns}">
        <xsl:element name="Code" namespace="{$ns}">
          <xsl:value-of select="ec2:code"/>
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
      </xsl:element>
    </xsl:for-each>
  </xsl:template>

  <xsl:template match="ec2:instanceState">
    <xsl:element name="InstanceState" namespace="{$ns}">
      <xsl:element name="Code" namespace="{$ns}">
        <xsl:value-of select="ec2:code"/>
      </xsl:element>
      <xsl:element name="Name" namespace="{$ns}">
        <xsl:value-of select="ec2:name"/>
      </xsl:element>
    </xsl:element>
  </xsl:template>

</xsl:stylesheet>

