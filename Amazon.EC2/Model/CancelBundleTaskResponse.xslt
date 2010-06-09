<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform" xmlns:ec2="http://ec2.amazonaws.com/doc/2009-11-30/" exclude-result-prefixes="ec2">
    <xsl:output method="xml" omit-xml-declaration="no" indent="yes"/>
    <xsl:variable name="ns" select="'http://ec2.amazonaws.com/doc/2009-11-30/'"/>
    <xsl:template match="ec2:CancelBundleTaskResponse">
        <xsl:element name="CancelBundleTaskResponse" namespace="{$ns}">
            <xsl:element name="ResponseMetadata" namespace="{$ns}">
                <xsl:element name="RequestId" namespace="{$ns}">
                    <xsl:value-of select="ec2:requestId"/>
                </xsl:element>
            </xsl:element>
            <xsl:element name="CancelBundleTaskResult" namespace="{$ns}">
                <xsl:apply-templates select="ec2:bundleInstanceTask"/>
            </xsl:element>
        </xsl:element>
    </xsl:template>
    <xsl:template match="ec2:bundleInstanceTask">
        <xsl:element name="BundleTask" namespace="{$ns}">
            <xsl:element name="InstanceId" namespace="{$ns}">
                <xsl:value-of select="ec2:instanceId"/>
            </xsl:element>
            <xsl:element name="BundleId" namespace="{$ns}">
                <xsl:value-of select="ec2:bundleId"/>
            </xsl:element>
            <xsl:element name="BundleState" namespace="{$ns}">
                <xsl:value-of select="ec2:state"/>
            </xsl:element>
            <xsl:element name="StartTime" namespace="{$ns}">
                <xsl:value-of select="ec2:startTime"/>
            </xsl:element>
            <xsl:element name="UpdateTime" namespace="{$ns}">
                <xsl:value-of select="ec2:updateTime"/>
            </xsl:element>
            <xsl:apply-templates select="ec2:storage"/>
            <xsl:element name="Progress" namespace="{$ns}">
                <xsl:value-of select="ec2:progress"/>
            </xsl:element>
            <xsl:apply-templates select="ec2:error"/>
        </xsl:element>
    </xsl:template>
    <xsl:template match="ec2:storage">
        <xsl:element name="Storage" namespace="{$ns}">
            <xsl:element name="S3" namespace="{$ns}">
                <xsl:element name="Bucket" namespace="{$ns}">
                    <xsl:value-of select="ec2:S3/ec2:bucket"/>
                </xsl:element>
                <xsl:element name="Prefix" namespace="{$ns}">
                    <xsl:value-of select="ec2:S3/ec2:prefix"/>
                </xsl:element>
            </xsl:element>
        </xsl:element>
    </xsl:template>
    <xsl:template match="ec2:error">
        <xsl:element name="BundleTaskError" namespace="{$ns}">
            <xsl:element name="Code" namespace="{$ns}">
                <xsl:value-of select="ec2:code"/>
            </xsl:element>
            <xsl:element name="Message" namespace="{$ns}">
                <xsl:value-of select="ec2:message"/>
            </xsl:element>
        </xsl:element>
    </xsl:template>
</xsl:stylesheet>
