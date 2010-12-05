<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0"
	xmlns:xsl="http://www.w3.org/1999/XSL/Transform" xmlns:ec2="http://ec2.amazonaws.com/doc/2010-08-31/"
	exclude-result-prefixes="ec2">
  <xsl:output method="xml" omit-xml-declaration="no" indent="yes" />
  <xsl:variable name="ns" select="'http://ec2.amazonaws.com/doc/2010-08-31/'" />
  <xsl:template match="ec2:DescribeTagsResponse">
    <xsl:element name="DescribeTagsResponse" namespace="{$ns}">
      <xsl:element name="ResponseMetadata" namespace="{$ns}">
        <xsl:element name="RequestId" namespace="{$ns}">
          <xsl:value-of select="ec2:requestId" />
        </xsl:element>
      </xsl:element>
      <xsl:element name="DescribeTagsResult" namespace="{$ns}">
        <xsl:apply-templates select="ec2:tagSet" />
      </xsl:element>
    </xsl:element>
  </xsl:template>
  <xsl:template match="ec2:tagSet">
    <xsl:for-each select="ec2:item">
      <xsl:element name="ResourceTag" namespace="{$ns}">
        <xsl:element name="ResourceId" namespace="{$ns}">
          <xsl:value-of select="ec2:resourceId" />
        </xsl:element>
        <xsl:element name="ResourceType" namespace="{$ns}">
          <xsl:value-of select="ec2:resourceType" />
        </xsl:element>
        <xsl:element name="Key" namespace="{$ns}">
          <xsl:value-of select="ec2:key" />
        </xsl:element>
        <xsl:element name="Value" namespace="{$ns}">
          <xsl:value-of select="ec2:value" />
        </xsl:element>
      </xsl:element>
    </xsl:for-each>
  </xsl:template>
</xsl:stylesheet>
