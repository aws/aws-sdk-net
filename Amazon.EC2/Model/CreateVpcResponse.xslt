<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform" xmlns:ec2="http://ec2.amazonaws.com/doc/2009-11-30/" exclude-result-prefixes="ec2">
    <xsl:output method="xml" omit-xml-declaration="no" indent="yes"/>
    <xsl:variable name="ns" select="'http://ec2.amazonaws.com/doc/2009-11-30/'"/>
    <xsl:template match="ec2:CreateVpcResponse">
        <xsl:element name="CreateVpcResponse" namespace="{$ns}">
            <xsl:element name="ResponseMetadata" namespace="{$ns}">
                <xsl:element name="RequestId" namespace="{$ns}">
                    <xsl:value-of select="ec2:requestId"/>
                </xsl:element>
            </xsl:element>
            <xsl:element name="CreateVpcResult" namespace="{$ns}">
                <xsl:apply-templates select="ec2:vpc"/>
            </xsl:element>
        </xsl:element>
    </xsl:template>
    <xsl:template match="ec2:vpc">
        <xsl:element name="Vpc" namespace="{$ns}">
            <xsl:element name="VpcId" namespace="{$ns}">
                <xsl:value-of select="ec2:vpcId"/>
            </xsl:element>
            <xsl:element name="VpcState" namespace="{$ns}">
                <xsl:value-of select="ec2:state"/>
            </xsl:element>
            <xsl:element name="CidrBlock" namespace="{$ns}">
                <xsl:value-of select="ec2:cidrBlock"/>
            </xsl:element>
            <xsl:element name="DhcpOptionsId" namespace="{$ns}">
                <xsl:value-of select="ec2:dhcpOptionsId"/>
            </xsl:element>
        </xsl:element>
    </xsl:template>
</xsl:stylesheet>

		  
