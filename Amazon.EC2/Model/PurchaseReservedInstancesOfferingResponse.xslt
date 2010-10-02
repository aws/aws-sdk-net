<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform" xmlns:ec2="http://ec2.amazonaws.com/doc/2010-08-31/" exclude-result-prefixes="ec2">
    <xsl:output method="xml" omit-xml-declaration="no" indent="yes"/>
    <xsl:variable name="ns" select="'http://ec2.amazonaws.com/doc/2010-08-31/'"/>
    <xsl:template match="ec2:PurchaseReservedInstancesOfferingResponse">
        <xsl:element name="PurchaseReservedInstancesOfferingResponse" namespace="{$ns}">
            <xsl:element name="ResponseMetadata" namespace="{$ns}">
                <xsl:element name="RequestId" namespace="{$ns}">
                    <xsl:value-of select="ec2:requestId"/>
                </xsl:element>
            </xsl:element>
            <xsl:element name="PurchaseReservedInstancesOfferingResult" namespace="{$ns}">
                <xsl:element name="ReservedInstancesId" namespace="{$ns}">
                    <xsl:value-of select="ec2:reservedInstancesId"/>
                </xsl:element>
            </xsl:element>
        </xsl:element>
    </xsl:template>
</xsl:stylesheet>
