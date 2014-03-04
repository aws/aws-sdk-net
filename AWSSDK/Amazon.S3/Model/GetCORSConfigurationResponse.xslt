﻿<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform" xmlns:s3="http://s3.amazonaws.com/doc/2006-03-01/" exclude-result-prefixes="xsl s3">
  <xsl:output method="xml" omit-xml-declaration="no" indent="yes"/>
  <xsl:variable name="ns" select="'http://s3.amazonaws.com/doc/2006-03-01/'"/>

  <xsl:template match="s3:CORSConfiguration">
    <xsl:element name="GetCORSConfigurationResponse" namespace="{$ns}">
      <xsl:element name="Configuration" namespace="{$ns}">
        <xsl:element name="Rules" namespace="{$ns}">
          <xsl:apply-templates select="s3:CORSRule"/>
        </xsl:element>
      </xsl:element>
    </xsl:element>
  </xsl:template>

  <xsl:template match="s3:CORSRule">
    <xsl:element name="CORSRule" namespace="{$ns}">
      <xsl:apply-templates />
    </xsl:element>
  </xsl:template>

  <xsl:template match="@* | node()">
        <xsl:copy>
            <xsl:apply-templates select="@* | node()"/>
        </xsl:copy>
    </xsl:template>
</xsl:stylesheet>
