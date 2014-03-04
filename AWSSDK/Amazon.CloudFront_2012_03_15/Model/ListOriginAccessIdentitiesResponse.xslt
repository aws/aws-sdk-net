<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
        xmlns:cf="http://cloudfront.amazonaws.com/doc/2010-11-01/" exclude-result-prefixes="xsl cf">
  <xsl:output method="xml" omit-xml-declaration="no" indent="yes"/>
  <xsl:variable name="ns" select="'http://cloudfront.amazonaws.com/doc/2010-11-01/'"/>

  <xsl:template match="cf:CloudFrontOriginAccessIdentityList">
    <xsl:element name="ListOriginAccessIdentitiesResponse" namespace="{$ns}">
      <xsl:apply-templates/>
    </xsl:element>
  </xsl:template>

  <xsl:template match="cf:CloudFrontOriginAccessIdentitySummary">
    <xsl:element name="OriginAccessIdentities" namespace="{$ns}">
      <xsl:apply-templates/>
    </xsl:element>
  </xsl:template>

  <xsl:template match="cf:Comment">
    <xsl:element name="OriginAccessIdentityConfig" namespace="{$ns}">
      <xsl:element name="Comment" namespace="{$ns}">
        <xsl:apply-templates/>
      </xsl:element>
    </xsl:element>
  </xsl:template>

  <xsl:template match="@* | node()">
    <xsl:copy>
      <xsl:apply-templates select="@* | node()"/>
    </xsl:copy>
  </xsl:template>

</xsl:stylesheet>