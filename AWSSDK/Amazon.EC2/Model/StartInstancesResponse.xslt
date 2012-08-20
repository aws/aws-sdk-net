<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform" xmlns:ec2="default-ec2-namespace" exclude-result-prefixes="ec2">
    <xsl:output method="xml" omit-xml-declaration="no" indent="yes"/>
    <xsl:template match="ec2:StartInstancesResponse">
        <xsl:element name="StartInstancesResponse">
            <xsl:element name="ResponseMetadata">
                <xsl:element name="RequestId">
                    <xsl:value-of select="ec2:requestId"/>
                </xsl:element>
            </xsl:element>
            <xsl:element name="StartInstancesResult">
                <xsl:apply-templates select="ec2:instancesSet"/>
            </xsl:element>
        </xsl:element>
    </xsl:template>
    <xsl:template match="ec2:instancesSet">
        <xsl:for-each select="ec2:item">
            <xsl:element name="StartingInstances">
                <xsl:element name="InstanceId">
                    <xsl:value-of select="ec2:instanceId"/>
                </xsl:element>
                <xsl:element name="CurrentState">
                    <xsl:element name="Code">
                        <xsl:value-of select="ec2:currentState/ec2:code"/>
                    </xsl:element>
                    <xsl:element name="Name">
                        <xsl:value-of select="ec2:currentState/ec2:name"/>
                    </xsl:element>
                </xsl:element>
                <xsl:element name="PreviousState">
                    <xsl:element name="Code">
                        <xsl:value-of select="ec2:previousState/ec2:code"/>
                    </xsl:element>
                    <xsl:element name="Name">
                        <xsl:value-of select="ec2:previousState/ec2:name"/>
                    </xsl:element>
                </xsl:element>
            </xsl:element>
        </xsl:for-each>
    </xsl:template>
</xsl:stylesheet>
