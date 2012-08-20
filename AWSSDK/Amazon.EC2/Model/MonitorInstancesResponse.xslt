<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform" xmlns:ec2="default-ec2-namespace" exclude-result-prefixes="ec2">
    <xsl:output method="xml" omit-xml-declaration="no" indent="yes"/>
    <xsl:template match="ec2:MonitorInstancesResponse">
        <xsl:element name="MonitorInstancesResponse">
            <xsl:element name="ResponseMetadata">
                <xsl:element name="RequestId">
                    <xsl:value-of select="ec2:requestId"/>
                </xsl:element>
            </xsl:element>
            <xsl:element name="MonitorInstancesResult">
                <xsl:apply-templates select="ec2:instancesSet"/>
            </xsl:element>
        </xsl:element>
    </xsl:template>
    <xsl:template match="ec2:instancesSet">
        <xsl:for-each select="ec2:item">
            <xsl:element name="InstanceMonitoring">
                <xsl:element name="InstanceId">
                    <xsl:value-of select="ec2:instanceId"/>
                </xsl:element>
                <xsl:element name="Monitoring">
                    <xsl:element name="MonitoringState">
                        <xsl:value-of select="ec2:monitoring/ec2:state"/>
                    </xsl:element>
                </xsl:element>
            </xsl:element>
        </xsl:for-each>
    </xsl:template>
</xsl:stylesheet>
