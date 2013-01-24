<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform" xmlns:ec2="default-ec2-namespace" exclude-result-prefixes="ec2">
  <xsl:output method="xml" omit-xml-declaration="no" indent="yes"/>
  <xsl:template match="ec2:DescribeAccountAttributesResponse">
    <xsl:element name="DescribeAccountAttributesResponse">
      <xsl:element name="ResponseMetadata">
        <xsl:element name="RequestId">
          <xsl:value-of select="ec2:requestId"/>
        </xsl:element>
      </xsl:element>
      <xsl:element name="DescribeAccountAttributesResult">
        <xsl:apply-templates select="ec2:accountAttributeSet"/>
      </xsl:element>
    </xsl:element>
  </xsl:template>
  <xsl:template match="ec2:accountAttributeSet">
    <xsl:for-each select="ec2:item">
      <xsl:element name="AccountAttributes">
        <xsl:element name="AttributeName">
          <xsl:value-of select="ec2:attributeName" />
        </xsl:element>
        <xsl:apply-templates select="ec2:attributeValueSet"/>
      </xsl:element>
    </xsl:for-each>
  </xsl:template>
  <xsl:template match="ec2:attributeValueSet">
    <xsl:for-each select="ec2:item">
      <xsl:element name="AttributeValues">
        <xsl:element name="AttributeValue">
          <xsl:value-of select="ec2:attributeValue" />
        </xsl:element>
      </xsl:element>
    </xsl:for-each>
  </xsl:template>
</xsl:stylesheet>


