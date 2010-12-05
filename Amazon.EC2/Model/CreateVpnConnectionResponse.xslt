<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet version="1.0"
    xmlns:xsl="http://www.w3.org/1999/XSL/Transform" xmlns:ec2="http://ec2.amazonaws.com/doc/2010-08-31/"
    exclude-result-prefixes="ec2">
    <xsl:output method="xml" omit-xml-declaration="no" indent="yes" />
    <xsl:variable name="ns"
        select="'http://ec2.amazonaws.com/doc/2010-08-31/'" />
    <xsl:template match="ec2:CreateVpnConnectionResponse">
        <xsl:element name="CreateVpnConnectionResponse" namespace="{$ns}">
            <xsl:element name="ResponseMetadata" namespace="{$ns}">
                <xsl:element name="RequestId" namespace="{$ns}">
                    <xsl:value-of select="ec2:requestId" />
                </xsl:element>
            </xsl:element>
            <xsl:element name="CreateVpnConnectionResult" namespace="{$ns}">
                <xsl:apply-templates select="ec2:vpnConnection" />
            </xsl:element>
        </xsl:element>
    </xsl:template>
    <xsl:template match="ec2:vpnConnection">
        <xsl:element name="VpnConnection" namespace="{$ns}">
            <xsl:element name="VpnConnectionId" namespace="{$ns}">
                <xsl:value-of select="ec2:vpnConnectionId" />
            </xsl:element>
            <xsl:element name="VpnConnectionState" namespace="{$ns}">
                <xsl:value-of select="ec2:state" />
            </xsl:element>
            <xsl:element name="CustomerGatewayConfiguration" namespace="{$ns}">
                <xsl:value-of select="ec2:customerGatewayConfiguration" />
            </xsl:element>
            <xsl:element name="Type" namespace="{$ns}">
                <xsl:value-of select="ec2:type" />
            </xsl:element>
            <xsl:element name="CustomerGatewayId" namespace="{$ns}">
                <xsl:value-of select="ec2:customerGatewayId" />
            </xsl:element>
            <xsl:element name="VpnGatewayId" namespace="{$ns}">
                <xsl:value-of select="ec2:vpnGatewayId" />
            </xsl:element>
        </xsl:element>
    </xsl:template>
</xsl:stylesheet>
