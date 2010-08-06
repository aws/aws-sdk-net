<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform" xmlns:ec2="http://ec2.amazonaws.com/doc/2009-11-30/" exclude-result-prefixes="ec2">
    <xsl:output method="xml" omit-xml-declaration="no" indent="yes"/>
    <xsl:variable name="ns" select="'http://ec2.amazonaws.com/doc/2009-11-30/'"/>
    <xsl:template match="ec2:CreateVolumeResponse">
        <xsl:element name="CreateVolumeResponse" namespace="{$ns}">
            <xsl:element name="ResponseMetadata" namespace="{$ns}">
                <xsl:element name="RequestId" namespace="{$ns}">
                    <xsl:value-of select="ec2:requestId"/>
                </xsl:element>
            </xsl:element>
            <xsl:element name="CreateVolumeResult" namespace="{$ns}">
                <xsl:element name="Volume" namespace="{$ns}">
                    <xsl:element name="VolumeId" namespace="{$ns}">
                        <xsl:value-of select="ec2:volumeId"/>
                    </xsl:element>
                    <xsl:element name="Size" namespace="{$ns}">
                        <xsl:value-of select="ec2:size"/>
                    </xsl:element>
                    <xsl:element name="SnapshotId" namespace="{$ns}">
                        <xsl:value-of select="ec2:snapshotId"/>
                    </xsl:element>
                    <xsl:element name="AvailabilityZone" namespace="{$ns}">
                        <xsl:value-of select="ec2:availabilityZone"/>
                    </xsl:element>
                    <xsl:element name="Status" namespace="{$ns}">
                        <xsl:value-of select="ec2:status"/>
                    </xsl:element>
                    <xsl:element name="CreateTime" namespace="{$ns}">
                        <xsl:value-of select="ec2:createTime"/>
                    </xsl:element>
                    <xsl:element name="Progress" namespace="{$ns}">
                        <xsl:value-of select="ec2:progress"/>
                    </xsl:element>
                </xsl:element>
            </xsl:element>
        </xsl:element>
    </xsl:template>
</xsl:stylesheet>
