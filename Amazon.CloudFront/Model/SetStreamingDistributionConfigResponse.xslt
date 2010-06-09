<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
  xmlns:cf="http://cloudfront.amazonaws.com/doc/2009-12-01/" exclude-result-prefixes="xsl cf">
  <xsl:variable name="ns" select="'http://cloudfront.amazonaws.com/doc/2009-12-01/'"/>
  <xsl:output method="xml" indent="yes"/>

  <xsl:template match="cf:StreamingDistribution">
    <xsl:element name="SetStreamingDistributionConfigResponse" namespace="{$ns}">
      <xsl:element name="StreamingDistribution" namespace="{$ns}">
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