<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet
  version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
  xmlns:ec2="default-ec2-namespace" exclude-result-prefixes="ec2">
    <xsl:output method="xml" omit-xml-declaration="no" indent="yes"/>
    <xsl:template match="ec2:DescribeKeyPairsResponse">
        <xsl:element name="DescribeKeyPairsResponse">
            <xsl:element name="ResponseMetadata">
                <xsl:element name="RequestId">
                    <xsl:value-of select="ec2:requestId"/>
                </xsl:element>
            </xsl:element>
            <xsl:element name="DescribeKeyPairsResult">
                <xsl:apply-templates select="ec2:keySet"/>
            </xsl:element>
        </xsl:element>
    </xsl:template>
    <xsl:template match="ec2:keySet">
        <xsl:for-each select="ec2:item">
            <xsl:element name="KeyPair">
                <xsl:element name="KeyName">
                    <xsl:value-of select="ec2:keyName"/>
                </xsl:element>
                <xsl:element name="KeyFingerprint">
                    <xsl:value-of select="ec2:keyFingerprint"/>
                </xsl:element>
            </xsl:element>
        </xsl:for-each>
    </xsl:template>
</xsl:stylesheet>
