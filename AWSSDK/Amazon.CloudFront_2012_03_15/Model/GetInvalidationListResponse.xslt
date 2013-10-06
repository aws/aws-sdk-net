<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
  xmlns:cf="http://cloudfront.amazonaws.com/doc/2010-11-01/" exclude-result-prefixes="xsl cf">
  <xsl:variable name="ns" select="'http://cloudfront.amazonaws.com/doc/2010-11-01/'"/>
  <xsl:output method="xml" indent="yes"/>

  <xsl:template match="cf:InvalidationList">
    <xsl:element name="GetInvalidationListResponse">
      <xsl:element name="RequestId">
        <xsl:value-of select="cf:RequestId"/>
      </xsl:element>
      <xsl:element name="Marker">
        <xsl:value-of select="cf:Marker"/>
      </xsl:element>
      <xsl:element name="NextMarker">
        <xsl:value-of select="cf:NextMarker"/>
      </xsl:element>
      <xsl:element name="MaxItems">
        <xsl:value-of select="cf:MaxItems"/>
      </xsl:element>
      <xsl:element name="IsTruncated">
        <xsl:value-of select="cf:IsTruncated"/>
      </xsl:element>

      <xsl:element name="Summaries">
        <xsl:apply-templates/>
      </xsl:element>
    </xsl:element>
  </xsl:template>

  <xsl:template match="cf:InvalidationSummary">
    <xsl:element name="InvalidationSummary">
      <xsl:element name="Id">
        <xsl:value-of select="cf:Id"/>
      </xsl:element>
      <xsl:element name="Status">
        <xsl:value-of select="cf:Status"/>
      </xsl:element>
    </xsl:element>
  </xsl:template>

</xsl:stylesheet>
