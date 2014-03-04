<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
        xmlns:cf="http://cloudfront.amazonaws.com/doc/2010-11-01/" exclude-result-prefixes="xsl cf">
  <xsl:output method="xml" omit-xml-declaration="no" indent="yes"/>
  <xsl:variable name="ns" select="'http://cloudfront.amazonaws.com/doc/2010-11-01/'"/>

  <xsl:template match="cf:DistributionList">
    <xsl:element name="ListDistributionsResponse" namespace="{$ns}">
      <xsl:apply-templates/>
    </xsl:element>
  </xsl:template>

  <xsl:template match="cf:DistributionSummary">
    <xsl:element name="Distribution" namespace="{$ns}">
      <xsl:element name="Id" namespace="{$ns}">
        <xsl:value-of select="cf:Id"/>
      </xsl:element>
      <xsl:element name="DomainName" namespace="{$ns}">
        <xsl:value-of select="cf:DomainName"/>
      </xsl:element>
      <xsl:element name="Status" namespace="{$ns}">
        <xsl:value-of select="cf:Status"/>
      </xsl:element>
      <xsl:element name="LastModifiedTime" namespace="{$ns}">
        <xsl:value-of select="cf:LastModifiedTime"/>
      </xsl:element>
      <xsl:element name="DistributionConfig" namespace="{$ns}">
        <xsl:apply-templates />
      </xsl:element>
    </xsl:element>
  </xsl:template>

  <xsl:template match="cf:Bucket[local-name(..)='Logging']">
    <xsl:element name="First" namespace="{$ns}">
      <xsl:value-of select="."/>
    </xsl:element>
  </xsl:template>

  <xsl:template match="cf:Prefix[local-name(..)='Logging']">
    <xsl:element name="Second" namespace="{$ns}">
      <xsl:value-of select="."/>
    </xsl:element>
  </xsl:template>

  <xsl:template match="cf:RequiredProtocols">
    <xsl:apply-templates/>
  </xsl:template>

  <xsl:template match="cf:Self[local-name(..)='Signer'] | cf:Self[local-name(..)='TrustedSigners']">
    <xsl:element name="Self" namespace="{$ns}">
      <xsl:text>true</xsl:text>
    </xsl:element>
  </xsl:template>

  <xsl:template match="@* | node()">
    <xsl:copy>
      <xsl:apply-templates select="@* | node()"/>
    </xsl:copy>
  </xsl:template>
</xsl:stylesheet>