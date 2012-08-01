<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform" xmlns:ec2="default-ec2-namespace" exclude-result-prefixes="ec2">
    <xsl:output method="xml" omit-xml-declaration="no" indent="yes"/>
    <xsl:template match="ec2:DescribeBundleTasksResponse">
        <xsl:element name="DescribeBundleTasksResponse">
            <xsl:element name="ResponseMetadata">
                <xsl:element name="RequestId">
                    <xsl:value-of select="ec2:requestId"/>
                </xsl:element>
            </xsl:element>
            <xsl:element name="DescribeBundleTasksResult">
                <xsl:apply-templates select="ec2:bundleInstanceTasksSet"/>
            </xsl:element>
        </xsl:element>
    </xsl:template>
    <xsl:template match="ec2:bundleInstanceTasksSet">
        <xsl:for-each select="ec2:item">
            <xsl:element name="BundleTask">
                <xsl:element name="InstanceId">
                    <xsl:value-of select="ec2:instanceId"/>
                </xsl:element>
                <xsl:element name="BundleId">
                    <xsl:value-of select="ec2:bundleId"/>
                </xsl:element>
                <xsl:element name="BundleState">
                    <xsl:value-of select="ec2:state"/>
                </xsl:element>
                <xsl:element name="StartTime">
                    <xsl:value-of select="ec2:startTime"/>
                </xsl:element>
                <xsl:element name="UpdateTime">
                    <xsl:value-of select="ec2:updateTime"/>
                </xsl:element>
                <xsl:apply-templates select="ec2:storage"/>
                <xsl:element name="Progress">
                    <xsl:value-of select="ec2:progress"/>
                </xsl:element>
                <xsl:apply-templates select="ec2:error"/>
            </xsl:element>
        </xsl:for-each>
    </xsl:template>
    <xsl:template match="ec2:storage">
        <xsl:element name="Storage">
            <xsl:element name="S3">
                <xsl:element name="Bucket">
                    <xsl:value-of select="ec2:S3/ec2:bucket"/>
                </xsl:element>
                <xsl:element name="Prefix">
                    <xsl:value-of select="ec2:S3/ec2:prefix"/>
                </xsl:element>
            </xsl:element>
        </xsl:element>
    </xsl:template>
    <xsl:template match="ec2:error">
        <xsl:element name="BundleTaskError">
            <xsl:element name="Code">
                <xsl:value-of select="ec2:code"/>
            </xsl:element>
            <xsl:element name="Message">
                <xsl:value-of select="ec2:message"/>
            </xsl:element>
        </xsl:element>
    </xsl:template>
</xsl:stylesheet>
