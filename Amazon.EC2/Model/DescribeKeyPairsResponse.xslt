<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform" xmlns:ec2="http://ec2.amazonaws.com/doc/2009-11-30/" exclude-result-prefixes="ec2">
    <xsl:output method="xml" omit-xml-declaration="no" indent="yes"/>
    <xsl:variable name="ns" select="'http://ec2.amazonaws.com/doc/2009-11-30/'"/>
    <xsl:template match="ec2:DescribeKeyPairsResponse">
        <xsl:element name="DescribeKeyPairsResponse" namespace="{$ns}">
            <xsl:element name="ResponseMetadata" namespace="{$ns}">
                <xsl:element name="RequestId" namespace="{$ns}">
                    <xsl:value-of select="ec2:requestId"/>
                </xsl:element>
            </xsl:element>
            <xsl:element name="DescribeKeyPairsResult" namespace="{$ns}">
                <xsl:apply-templates select="ec2:keySet"/>
            </xsl:element>
        </xsl:element>
    </xsl:template>
    <xsl:template match="ec2:keySet">
        <xsl:for-each select="ec2:item">
            <xsl:element name="KeyPair" namespace="{$ns}">
                <xsl:element name="KeyName" namespace="{$ns}">
                    <xsl:value-of select="ec2:keyName"/>
                </xsl:element>
                <xsl:element name="KeyFingerprint" namespace="{$ns}">
                    <xsl:value-of select="ec2:keyFingerprint"/>
                </xsl:element>
            </xsl:element>
        </xsl:for-each>
    </xsl:template>
</xsl:stylesheet>
