<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform" xmlns:ec2="http://ec2.amazonaws.com/doc/2009-11-30/" exclude-result-prefixes="ec2">
    <xsl:output method="xml" omit-xml-declaration="no" indent="yes"/>
    <xsl:variable name="ns" select="'http://ec2.amazonaws.com/doc/2009-11-30/'"/>
    <xsl:template match="ec2:DescribeReservedInstancesResponse">
        <xsl:element name="DescribeReservedInstancesResponse" namespace="{$ns}">
            <xsl:element name="ResponseMetadata" namespace="{$ns}">
                <xsl:element name="RequestId" namespace="{$ns}">
                    <xsl:value-of select="ec2:requestId"/>
                </xsl:element>
            </xsl:element>
            <xsl:element name="DescribeReservedInstancesResult" namespace="{$ns}">
                <xsl:apply-templates select="ec2:reservedInstancesSet"/>
            </xsl:element>
        </xsl:element>
    </xsl:template>
    <xsl:template match="ec2:reservedInstancesSet">
        <xsl:for-each select="ec2:item">
            <xsl:element name="ReservedInstances" namespace="{$ns}">
                <xsl:element name="ReservedInstancesId" namespace="{$ns}">
                    <xsl:value-of select="ec2:reservedInstancesId"/>
                </xsl:element>
                <xsl:element name="InstanceType" namespace="{$ns}">
                    <xsl:value-of select="ec2:instanceType"/>
                </xsl:element>
                <xsl:element name="AvailabilityZone" namespace="{$ns}">
                    <xsl:value-of select="ec2:availabilityZone"/>
                </xsl:element>
                <xsl:element name="Duration" namespace="{$ns}">
                    <xsl:value-of select="ec2:duration"/>
                </xsl:element>
                <xsl:element name="UsagePrice" namespace="{$ns}">
                    <xsl:value-of select="ec2:usagePrice"/>
                </xsl:element>
                <xsl:element name="FixedPrice" namespace="{$ns}">
                    <xsl:value-of select="ec2:fixedPrice"/>
                </xsl:element>
                <xsl:element name="InstanceCount" namespace="{$ns}">
                    <xsl:value-of select="ec2:instanceCount"/>
                </xsl:element>
                <xsl:element name="ProductDescription" namespace="{$ns}">
                    <xsl:value-of select="ec2:productDescription"/>
                </xsl:element>
                <xsl:element name="PurchaseState" namespace="{$ns}">
                    <xsl:value-of select="ec2:state"/>
                </xsl:element>
                <xsl:element name="StartTime" namespace="{$ns}">
                    <xsl:value-of select="ec2:start"/>
                </xsl:element>
            </xsl:element>
        </xsl:for-each>
    </xsl:template>
</xsl:stylesheet>
