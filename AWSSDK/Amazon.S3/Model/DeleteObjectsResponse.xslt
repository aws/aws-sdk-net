<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform" xmlns:s3="http://s3.amazonaws.com/doc/2006-03-01/" exclude-result-prefixes="xsl s3">
  <xsl:output method="xml" omit-xml-declaration="no" indent="yes"/>
  <xsl:variable name="ns" select="'http://s3.amazonaws.com/doc/2006-03-01/'"/>

  <xsl:template match="s3:DeleteResult">
    <xsl:element name="DeleteObjectsErrorResponse" namespace="{$ns}">
      <xsl:element name="DeleteErrors" namespace="{$ns}">
        <xsl:apply-templates select="s3:Error"/>
      </xsl:element>
      <xsl:element name="DeletedObjects" namespace="{$ns}">
        <xsl:apply-templates select="s3:Deleted"/>
      </xsl:element>
    </xsl:element>
  </xsl:template>

  <xsl:template match="s3:Error">
    <xsl:element name="DeleteError" namespace="{$ns}">
      <xsl:apply-templates />
    </xsl:element>
  </xsl:template>

  <xsl:template match="s3:Deleted">
    <xsl:element name="DeletedObject" namespace="{$ns}">
      <xsl:apply-templates />
    </xsl:element>
  </xsl:template>

  <xsl:template match="@* | node()">
    <xsl:copy>
      <xsl:apply-templates select="@* | node()"/>
    </xsl:copy>
  </xsl:template>
</xsl:stylesheet>