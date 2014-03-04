<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform" xmlns:s3="http://s3.amazonaws.com/doc/2006-03-01/" exclude-result-prefixes="xsl s3">
  <xsl:output method="xml" omit-xml-declaration="no" indent="yes"/>
  <xsl:variable name="ns" select="'http://s3.amazonaws.com/doc/2006-03-01/'"/>

  <xsl:template match="s3:ListBucketResult">
    <xsl:element name="ListObjectsResponse" namespace="{$ns}">
      <xsl:apply-templates/>
    </xsl:element>
  </xsl:template>

  <xsl:template match="s3:Contents">
    <xsl:element name="S3Objects" namespace="{$ns}">
      <xsl:element name="BucketName" namespace="{$ns}">
        <xsl:value-of select="../s3:Name"/>
      </xsl:element>
      <xsl:apply-templates />
    </xsl:element>
  </xsl:template>

  <xsl:template match="s3:ID">
    <xsl:element name="Id" namespace="{$ns}">
      <xsl:value-of select="."/>
    </xsl:element>
  </xsl:template>

  <xsl:template match="s3:CommonPrefixes">
    <xsl:element name="CommonPrefixes" namespace="{$ns}">
      <xsl:value-of select="./s3:Prefix"/>
    </xsl:element>
  </xsl:template>

  <xsl:template match="@* | node()">
    <xsl:copy>
      <xsl:apply-templates select="@* | node()"/>
    </xsl:copy>
  </xsl:template>
</xsl:stylesheet>