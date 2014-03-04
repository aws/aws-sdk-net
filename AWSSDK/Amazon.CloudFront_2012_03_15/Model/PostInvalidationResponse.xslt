<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
  xmlns:cf="http://cloudfront.amazonaws.com/doc/2010-11-01/" exclude-result-prefixes="xsl cf">
  <xsl:variable name="ns" select="'http://cloudfront.amazonaws.com/doc/2010-11-01/'"/>
  <xsl:output method="xml" indent="yes"/>

  <xsl:template match="cf:Invalidation">
    <xsl:element name="PostInvalidationResponse">
      <xsl:element name="RequestId">
        <xsl:value-of select="cf:RequestId"/>
      </xsl:element>
      <xsl:element name="Status">
        <xsl:value-of select="cf:Status"/>
      </xsl:element>
      <xsl:element name="Id">
        <xsl:value-of select="cf:Id"/>
      </xsl:element>
      <xsl:element name="CreateTime">
        <xsl:value-of select="cf:CreateTime"/>
      </xsl:element>
      <xsl:apply-templates/>
    </xsl:element>
  </xsl:template>

  <xsl:template match="cf:InvalidationBatch">
    <xsl:element name="InvalidationBatch">
      <xsl:element name="CallerReference">
        <xsl:value-of select="cf:CallerReference"/>
      </xsl:element>
      <xsl:element name="Paths">
        <xsl:apply-templates/>
      </xsl:element>
    </xsl:element>
  </xsl:template>
  
  <xsl:template match="cf:Path">
    <xsl:element name="string">
      <xsl:apply-templates/>
    </xsl:element>
  </xsl:template>

</xsl:stylesheet>
