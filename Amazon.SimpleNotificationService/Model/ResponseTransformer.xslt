<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform" xmlns:sns="http://sns.amazonaws.com/doc/2010-03-31/" exclude-result-prefixes="xsl sns">
  <xsl:output method="xml" omit-xml-declaration="yes" indent="yes"/>
  <xsl:variable name="ns" select="'http://sns.amazonaws.com/doc/2010-03-31/'" />

  <xsl:template match="sns:Attributes">
    <xsl:apply-templates select="sns:entry"/>
  </xsl:template>

  <xsl:template match="sns:entry">
    <xsl:element name="Attributes" namespace="{$ns}">
      <xsl:element name="Key" namespace="{$ns}">
        <xsl:value-of select="./sns:key"/>
      </xsl:element>
      <xsl:element name="Value" namespace="{$ns}">
        <xsl:value-of select="./sns:value"/>
      </xsl:element>
    </xsl:element>
  </xsl:template>

  <xsl:template match="*[local-name(child::*)='member']">
    <xsl:apply-templates select="child::node()"/>
  </xsl:template>
  <xsl:template match="*[local-name()='member']">
    <xsl:variable name="nodeName">
      <xsl:value-of select="name(parent::node())"/>
    </xsl:variable>
    <xsl:element name="{$nodeName}"  namespace="{$ns}">
      <xsl:apply-templates/>
    </xsl:element>
  </xsl:template>

  <xsl:template match="node() | @*">
    <xsl:if test="count(descendant::text()[string-length(.)>0]|*)">
      <xsl:copy>
        <xsl:apply-templates select="@*|node()" />
      </xsl:copy>
    </xsl:if>
  </xsl:template>

  <xsl:template match="text()">
    <xsl:value-of select="." />
  </xsl:template>
</xsl:stylesheet>
