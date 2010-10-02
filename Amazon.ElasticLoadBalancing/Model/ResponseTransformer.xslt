<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform" xmlns:aws="http://elasticloadbalancing.amazonaws.com/doc/2009-11-25/" exclude-result-prefixes="aws">
    <xsl:output method="xml" omit-xml-declaration="yes" indent="yes"/>
    <xsl:variable name="ns" select="'http://elasticloadbalancing.amazonaws.com/doc/2009-11-25/'"/>

    <xsl:template match="*[local-name(child::*)='member']">
        <xsl:apply-templates select="child::node()"/>
    </xsl:template>
    <xsl:template match="*[local-name()='member']">
        <xsl:variable name="nodeName">
            <xsl:value-of select="name(parent::node())"/>
        </xsl:variable>
        <xsl:element name="{$nodeName}"  namespace="{$ns}">
            <xsl:apply-templates/>
        </xsl:element>
    </xsl:template>

    <xsl:template match="node() | @*">
        <xsl:if test="count(descendant::text()[string-length(.)>0]|*)">
            <xsl:copy>
                <xsl:apply-templates select="@*|node()" />
            </xsl:copy>
        </xsl:if>
    </xsl:template>
    <xsl:template match="text()">
        <xsl:value-of select="." />
    </xsl:template>
</xsl:stylesheet>









