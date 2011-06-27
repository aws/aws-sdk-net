<?xml version="1.0" encoding="utf-8" ?>
<xsl:stylesheet version="1.0"
	xmlns:xsl="http://www.w3.org/1999/XSL/Transform" xmlns:ec2="http://ec2.amazonaws.com/doc/2011-05-15/"
	exclude-result-prefixes="ec2">
  <xsl:output method="xml" omit-xml-declaration="no" indent="yes" />
  <xsl:variable name="ns"
		select="'http://ec2.amazonaws.com/doc/2011-05-15/'" />
  <xsl:template match="ec2:CreateRouteTableResponse">
    <xsl:element name="CreateRouteTableResponse"
			namespace="{$ns}">
      <xsl:element name="ResponseMetadata" namespace="{$ns}">
        <xsl:element name="RequestId" namespace="{$ns}">
          <xsl:value-of select="ec2:requestId" />
        </xsl:element>
      </xsl:element>
      <xsl:element name="CreateRouteTableResult"
				namespace="{$ns}">
        <xsl:apply-templates select="ec2:routeTable" />
      </xsl:element>
    </xsl:element>
  </xsl:template>

  <xsl:template match="ec2:routeTable">
    <xsl:element name="RouteTable" namespace="{$ns}">
      <xsl:element name="RouteTableId" namespace="{$ns}">
        <xsl:value-of select="ec2:routeTableId" />
      </xsl:element>
      <xsl:element name="VpcId" namespace="{$ns}">
        <xsl:value-of select="ec2:vpcId" />
      </xsl:element>

      <xsl:apply-templates select="ec2:routeSet" />
    </xsl:element>
  </xsl:template>

  <xsl:template match="ec2:routeSet">
    <xsl:for-each select="ec2:item">
      <xsl:element name="Routes" namespace="{$ns}">
        <xsl:element name="DestinationCidrBlock" namespace="{$ns}">
          <xsl:value-of select="ec2:destinationCidrBlock" />
        </xsl:element>
        <xsl:element name="GatewayId" namespace="{$ns}">
          <xsl:value-of select="ec2:gatewayId" />
        </xsl:element>
        <xsl:element name="State" namespace="{$ns}">
          <xsl:value-of select="ec2:state" />
        </xsl:element>
      </xsl:element>
    </xsl:for-each>
  </xsl:template>

</xsl:stylesheet>
