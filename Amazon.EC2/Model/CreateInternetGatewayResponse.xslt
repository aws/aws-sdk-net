<?xml version="1.0" encoding="utf-8" ?>
<xsl:stylesheet version="1.0"
	xmlns:xsl="http://www.w3.org/1999/XSL/Transform" xmlns:ec2="http://ec2.amazonaws.com/doc/2011-05-15/"
	exclude-result-prefixes="ec2">
	<xsl:output method="xml" omit-xml-declaration="no" indent="yes" />
	<xsl:variable name="ns"
		select="'http://ec2.amazonaws.com/doc/2011-05-15/'" />
	<xsl:template match="ec2:CreateInternetGatewayResponse">
		<xsl:element name="CreateInternetGatewayResponse"
			namespace="{$ns}">
			<xsl:element name="ResponseMetadata" namespace="{$ns}">
				<xsl:element name="RequestId" namespace="{$ns}">
					<xsl:value-of select="ec2:requestId" />
				</xsl:element>
			</xsl:element>
			<xsl:element name="CreateInternetGatewayResult"
				namespace="{$ns}">
				<xsl:apply-templates select="ec2:internetGateway" />
			</xsl:element>
		</xsl:element>
	</xsl:template>

  <xsl:template match="ec2:internetGateway">
    <xsl:element name="InternetGateway" namespace="{$ns}">
      <xsl:element name="InternetGatewayId" namespace="{$ns}">
        <xsl:value-of select="ec2:internetGatewayId" />
      </xsl:element>
    </xsl:element>
  </xsl:template>

</xsl:stylesheet>
