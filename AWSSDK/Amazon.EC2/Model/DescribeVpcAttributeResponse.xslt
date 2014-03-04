<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
                xmlns:ec2="default-ec2-namespace"
                exclude-result-prefixes="ec2">
  <xsl:output method="xml" omit-xml-declaration="no" indent="yes"/>

  <xsl:template match="ec2:DescribeVpcAttributeResponse">
    <xsl:element name="DescribeVpcAttributeResponse">
      <xsl:element name="ResponseMetadata">
        <xsl:element name="RequestId">
          <xsl:value-of select="ec2:requestId"/>
        </xsl:element>
      </xsl:element>
      <xsl:element name="DescribeVpcAttributeResult">
        <xsl:element name="VpcId">
          <xsl:value-of select="ec2:vpcId"/>
        </xsl:element>
        <xsl:if test="ec2:enableDnsSupport">
          <xsl:element name="EnableDnsSupport">
            <xsl:value-of select="ec2:enableDnsSupport/ec2:value"/>
          </xsl:element>
        </xsl:if>
        <xsl:if test="ec2:enableDnsHostnames">
          <xsl:element name="EnableDnsHostnames">
            <xsl:value-of select="ec2:enableDnsHostnames/ec2:value"/>
          </xsl:element>
        </xsl:if>
      </xsl:element>
    </xsl:element>
  </xsl:template>
</xsl:stylesheet>
