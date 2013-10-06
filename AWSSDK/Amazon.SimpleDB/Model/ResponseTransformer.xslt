<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
    xmlns:sdb="http://sdb.amazonaws.com/doc/2009-04-15/" exclude-result-prefixes="xsl sdb">
    <xsl:output method="xml" omit-xml-declaration="no" indent="yes"/>
    <xsl:variable name="ns" select="'http://sdb.amazonaws.com/doc/2009-04-15/'"/>

    <xsl:template match="sdb:Item">
        <xsl:element name="Item" namespace="{$ns}">
            <xsl:if test="string-length(sdb:Name/@encoding) > 0">
                <xsl:element name="NameEncoding" namespace="{$ns}">
                    <xsl:value-of select="sdb:Name/@encoding"/>
                </xsl:element>
            </xsl:if>
            <xsl:apply-templates/>
        </xsl:element>
    </xsl:template>

    <xsl:template match="sdb:Attribute">
        <xsl:element name="Attribute" namespace="{$ns}">
            <xsl:if test="string-length(sdb:Name/@encoding) > 0">
                <xsl:element name="NameEncoding" namespace="{$ns}">
                    <xsl:value-of select="sdb:Name/@encoding"/>
                </xsl:element>
            </xsl:if>
            <xsl:if test="string-length(sdb:Value/@encoding) > 0">
                <xsl:element name="ValueEncoding" namespace="{$ns}">
                    <xsl:value-of select="sdb:Value/@encoding"/>
                </xsl:element>
            </xsl:if>
            <xsl:apply-templates/>
        </xsl:element>
    </xsl:template>

    <xsl:template match="sdb:Name[local-name(..)='Item']">
        <xsl:element name="Name" namespace="{$ns}">
            <xsl:value-of select="."/>
        </xsl:element>
    </xsl:template>

    <xsl:template match="sdb:Name[local-name(..)='Attribute']">
        <xsl:element name="Name" namespace="{$ns}">
            <xsl:value-of select="."/>
        </xsl:element>
    </xsl:template>

    <xsl:template match="sdb:Value[local-name(..)='Attribute']">
        <xsl:element name="Value" namespace="{$ns}">
            <xsl:value-of select="."/>
        </xsl:element>
    </xsl:template>

    <xsl:template match="@* | node()">
        <xsl:copy>
            <xsl:apply-templates select="@* | node()"/>
        </xsl:copy>
    </xsl:template>
</xsl:stylesheet>
