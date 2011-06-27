<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform" xmlns:ec2="http://ec2.amazonaws.com/doc/2011-05-15/" exclude-result-prefixes="ec2">
    <xsl:output method="xml" omit-xml-declaration="no" indent="yes"/>
    <xsl:variable name="ns" select="'http://ec2.amazonaws.com/doc/2011-05-15/'"/>
    <xsl:template match="ec2:DescribeCustomerGatewaysResponse">
        <xsl:element name="DescribeCustomerGatewaysResponse" namespace="{$ns}">
            <xsl:element name="ResponseMetadata" namespace="{$ns}">
                <xsl:element name="RequestId" namespace="{$ns}">
                    <xsl:value-of select="ec2:requestId"/>
                </xsl:element>
            </xsl:element>
            <xsl:element name="DescribeCustomerGatewaysResult" namespace="{$ns}">
                <xsl:apply-templates select="ec2:customerGatewaySet"/>
            </xsl:element>
        </xsl:element>
    </xsl:template>
    <xsl:template match="ec2:customerGatewaySet">
        <xsl:apply-templates select="ec2:item"/>
    </xsl:template>
    <xsl:template match="ec2:item">
		<xsl:element name="CustomerGateway" namespace="{$ns}">
			<xsl:element name="CustomerGatewayId" namespace="{$ns}">
				<xsl:value-of select="ec2:customerGatewayId" />
			</xsl:element>
			<xsl:element name="CustomerGatewayState" namespace="{$ns}">
				<xsl:value-of select="ec2:state" />
			</xsl:element>
			<xsl:element name="Type" namespace="{$ns}">
				<xsl:value-of select="ec2:type" />
			</xsl:element>
			<xsl:element name="IpAddress" namespace="{$ns}">
				<xsl:value-of select="ec2:ipAddress" />
			</xsl:element>
			<xsl:element name="BgpAsn" namespace="{$ns}">
				<xsl:value-of select="ec2:bgpAsn" />
			</xsl:element>
      <xsl:apply-templates select="ec2:tagSet" />
		</xsl:element>
	</xsl:template>
  <xsl:template match="ec2:tagSet">
    <xsl:for-each select="ec2:item">
      <xsl:element name="Tag" namespace="{$ns}">
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
