<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform" xmlns:ec2="http://ec2.amazonaws.com/doc/2009-11-30/" exclude-result-prefixes="ec2">
    <xsl:output method="xml" omit-xml-declaration="no" indent="yes"/>
    <xsl:variable name="ns" select="'http://ec2.amazonaws.com/doc/2009-11-30/'"/>
    <xsl:template match="ec2:DescribeSecurityGroupsResponse">
        <xsl:element name="DescribeSecurityGroupsResponse" namespace="{$ns}">
            <xsl:element name="ResponseMetadata" namespace="{$ns}">
                <xsl:element name="RequestId" namespace="{$ns}">
                    <xsl:value-of select="ec2:requestId"/>
                </xsl:element>
            </xsl:element>
            <xsl:element name="DescribeSecurityGroupsResult" namespace="{$ns}">
                <xsl:apply-templates select="ec2:securityGroupInfo"/>
            </xsl:element>
        </xsl:element>
    </xsl:template>
    <xsl:template match="ec2:securityGroupInfo">
        <xsl:for-each select="ec2:item">
            <xsl:element name="SecurityGroup" namespace="{$ns}">
                <xsl:element name="OwnerId" namespace="{$ns}">
                    <xsl:value-of select="ec2:ownerId"/>
                </xsl:element>
                <xsl:element name="GroupName" namespace="{$ns}">
                    <xsl:value-of select="ec2:groupName"/>
                </xsl:element>
                <xsl:element name="GroupDescription" namespace="{$ns}">
                    <xsl:value-of select="ec2:groupDescription"/>
                </xsl:element>
                <xsl:apply-templates select="ec2:ipPermissions"/>
            </xsl:element>
        </xsl:for-each>
    </xsl:template>
    <xsl:template match="ec2:ipPermissions">
        <xsl:for-each select="ec2:item">
            <xsl:element name="IpPermission" namespace="{$ns}">
                <xsl:element name="IpProtocol" namespace="{$ns}">
                    <xsl:value-of select="ec2:ipProtocol"/>
                </xsl:element>
                <xsl:element name="FromPort" namespace="{$ns}">
                    <xsl:value-of select="ec2:fromPort"/>
                </xsl:element>
                <xsl:element name="ToPort" namespace="{$ns}">
                    <xsl:value-of select="ec2:toPort"/>
                </xsl:element>
                <xsl:apply-templates select="ec2:ipRanges"/>
                <xsl:apply-templates select="ec2:groups"/>
            </xsl:element>
        </xsl:for-each>
    </xsl:template>
    <xsl:template match="ec2:groups">
        <xsl:for-each select="ec2:item">
            <xsl:element name="UserIdGroupPair" namespace="{$ns}">
                <xsl:element name="UserId" namespace="{$ns}">
                    <xsl:value-of select="ec2:userId"/>
                </xsl:element>
                <xsl:element name="GroupName" namespace="{$ns}">
                    <xsl:value-of select="ec2:groupName"/>
                </xsl:element>
                <xsl:apply-templates select="ec2:ipRanges"/>
            </xsl:element>
        </xsl:for-each>
    </xsl:template>
    <xsl:template match="ec2:ipRanges">
        <xsl:for-each select="ec2:item">
            <xsl:element name="IpRange" namespace="{$ns}">
                <xsl:value-of select="ec2:cidrIp"/>
            </xsl:element>
        </xsl:for-each>
    </xsl:template>
</xsl:stylesheet>
