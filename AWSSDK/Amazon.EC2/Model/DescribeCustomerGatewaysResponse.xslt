<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform" xmlns:ec2="default-ec2-namespace" exclude-result-prefixes="ec2">
    <xsl:output method="xml" omit-xml-declaration="no" indent="yes"/>
    <xsl:template match="ec2:DescribeCustomerGatewaysResponse">
        <xsl:element name="DescribeCustomerGatewaysResponse">
            <xsl:element name="ResponseMetadata">
                <xsl:element name="RequestId">
                    <xsl:value-of select="ec2:requestId"/>
                </xsl:element>
            </xsl:element>
            <xsl:element name="DescribeCustomerGatewaysResult">
                <xsl:apply-templates select="ec2:customerGatewaySet"/>
            </xsl:element>
        </xsl:element>
    </xsl:template>
    <xsl:template match="ec2:customerGatewaySet">
        <xsl:apply-templates select="ec2:item"/>
    </xsl:template>
    <xsl:template match="ec2:item">
		<xsl:element name="CustomerGateway">
			<xsl:element name="CustomerGatewayId">
				<xsl:value-of select="ec2:customerGatewayId" />
			</xsl:element>
			<xsl:element name="CustomerGatewayState">
				<xsl:value-of select="ec2:state" />
			</xsl:element>
			<xsl:element name="Type">
				<xsl:value-of select="ec2:type" />
			</xsl:element>
			<xsl:element name="IpAddress">
				<xsl:value-of select="ec2:ipAddress" />
			</xsl:element>
			<xsl:element name="BgpAsn">
				<xsl:value-of select="ec2:bgpAsn" />
			</xsl:element>
      <xsl:apply-templates select="ec2:tagSet" />
		</xsl:element>
	</xsl:template>
  <xsl:template match="ec2:tagSet">
    <xsl:for-each select="ec2:item">
      <xsl:element name="Tag">
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
