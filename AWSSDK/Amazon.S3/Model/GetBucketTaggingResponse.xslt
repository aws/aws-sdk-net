<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform" xmlns:s3="http://s3.amazonaws.com/doc/2006-03-01/" exclude-result-prefixes="xsl s3">
  <xsl:output method="xml" omit-xml-declaration="no" indent="yes"/>
  <xsl:variable name="ns" select="'http://s3.amazonaws.com/doc/2006-03-01/'"/>
  <xsl:template match="s3:Tagging">
    <xsl:element name="GetBucketTaggingResponse" namespace="{$ns}">
      <xsl:apply-templates select="s3:TagSet" />
    </xsl:element>
  </xsl:template>


  <xsl:template match="s3:TagSet">
    <xsl:element name="TagSets" namespace="{$ns}">
      <xsl:apply-templates select="s3:Tag" />
    </xsl:element>
  </xsl:template>

  <xsl:template match="s3:Tag">
    <xsl:element name="TagSet" namespace="{$ns}">
      <xsl:element name="Key" namespace="{$ns}">
        <xsl:value-of select="s3:Key"/>
      </xsl:element>
      <xsl:element name="Value" namespace="{$ns}">
        <xsl:value-of select="s3:Value"/>
      </xsl:element>
    </xsl:element>
  </xsl:template>

</xsl:stylesheet>