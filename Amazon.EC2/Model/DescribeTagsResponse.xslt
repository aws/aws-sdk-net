<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0"
	xmlns:xsl="http://www.w3.org/1999/XSL/Transform" xmlns:ec2="default-ec2-namespace"
	exclude-result-prefixes="ec2">
  <xsl:output method="xml" omit-xml-declaration="no" indent="yes" />
  <xsl:template match="ec2:DescribeTagsResponse">
    <xsl:element name="DescribeTagsResponse">
      <xsl:element name="ResponseMetadata">
        <xsl:element name="RequestId">
          <xsl:value-of select="ec2:requestId" />
        </xsl:element>
      </xsl:element>
      <xsl:element name="DescribeTagsResult">
        <xsl:apply-templates select="ec2:tagSet" />
      </xsl:element>
    </xsl:element>
  </xsl:template>
  <xsl:template match="ec2:tagSet">
    <xsl:for-each select="ec2:item">
      <xsl:element name="ResourceTag">
        <xsl:element name="ResourceId">
          <xsl:value-of select="ec2:resourceId" />
        </xsl:element>
        <xsl:element name="ResourceType">
          <xsl:value-of select="ec2:resourceType" />
        </xsl:element>
        <xsl:element name="Key">
          <xsl:value-of select="ec2:key" />
        </xsl:element>
        <xsl:element name="Value">
          <xsl:value-of select="ec2:value" />
        </xsl:element>
      </xsl:element>
    </xsl:for-each>
  </xsl:template>
</xsl:stylesheet>
