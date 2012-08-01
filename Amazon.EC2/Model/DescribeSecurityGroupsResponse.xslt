<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform" xmlns:ec2="default-ec2-namespace" exclude-result-prefixes="ec2">
    <xsl:output method="xml" omit-xml-declaration="no" indent="yes"/>
    <xsl:template match="ec2:DescribeSecurityGroupsResponse">
        <xsl:element name="DescribeSecurityGroupsResponse">
            <xsl:element name="ResponseMetadata">
                <xsl:element name="RequestId">
                    <xsl:value-of select="ec2:requestId"/>
                </xsl:element>
            </xsl:element>
            <xsl:element name="DescribeSecurityGroupsResult">
                <xsl:apply-templates select="ec2:securityGroupInfo"/>
            </xsl:element>
        </xsl:element>
    </xsl:template>
    <xsl:template match="ec2:securityGroupInfo">
        <xsl:for-each select="ec2:item">
            <xsl:element name="SecurityGroup">
                <xsl:element name="OwnerId">
                    <xsl:value-of select="ec2:ownerId"/>
                </xsl:element>
                <xsl:element name="GroupName">
                    <xsl:value-of select="ec2:groupName"/>
                </xsl:element>
                <xsl:element name="GroupDescription">
                    <xsl:value-of select="ec2:groupDescription"/>
                </xsl:element>
                <xsl:element name="GroupId">
                  <xsl:value-of select="ec2:groupId"/>
                </xsl:element>
                <xsl:element name="VpcId">
                  <xsl:value-of select="ec2:vpcId"/>
                </xsl:element>
                <xsl:apply-templates select="ec2:tagSet" />
                <xsl:apply-templates select="ec2:ipPermissions"/>
                <xsl:apply-templates select="ec2:ipPermissionsEgress"/>

            </xsl:element>
        </xsl:for-each>
    </xsl:template>
  
    <xsl:template match="ec2:ipPermissions">
        <xsl:for-each select="ec2:item">
            <xsl:element name="IpPermission">
                <xsl:element name="IpProtocol">
                    <xsl:value-of select="ec2:ipProtocol"/>
                </xsl:element>

              <xsl:apply-templates select="ec2:fromPort"/>
              <xsl:apply-templates select="ec2:toPort"/>
              <xsl:apply-templates select="ec2:ipRanges"/>
                <xsl:apply-templates select="ec2:groups"/>
            </xsl:element>
        </xsl:for-each>
    </xsl:template>

  <xsl:template match="ec2:fromPort">
    <xsl:element name="FromPort">
      <xsl:value-of select="."/>
    </xsl:element>
  </xsl:template>

  <xsl:template match="ec2:toPort">
    <xsl:element name="ToPort">
      <xsl:value-of select="."/>
    </xsl:element>
  </xsl:template>

  <xsl:template match="ec2:ipPermissionsEgress">
    <xsl:for-each select="ec2:item">
      <xsl:element name="IpPermissionsEgress">
        <xsl:element name="IpProtocol">
          <xsl:value-of select="ec2:ipProtocol"/>
        </xsl:element>
        <xsl:apply-templates select="ec2:fromPort"/>
        <xsl:apply-templates select="ec2:toPort"/>
        <xsl:apply-templates select="ec2:ipRanges"/>
        <xsl:apply-templates select="ec2:groups"/>
      </xsl:element>
    </xsl:for-each>
  </xsl:template>
  
  <xsl:template match="ec2:groups">
        <xsl:for-each select="ec2:item">
            <xsl:element name="UserIdGroupPair">
                <xsl:element name="UserId">
                    <xsl:value-of select="ec2:userId"/>
                </xsl:element>
                <xsl:element name="GroupId">
                    <xsl:value-of select="ec2:groupId"/>
                </xsl:element>
                <xsl:element name="GroupName">
                    <xsl:value-of select="ec2:groupName"/>
                </xsl:element>
                <xsl:apply-templates select="ec2:ipRanges"/>
            </xsl:element>
        </xsl:for-each>
    </xsl:template>
  
    <xsl:template match="ec2:ipRanges">
        <xsl:for-each select="ec2:item">
            <xsl:element name="IpRange">
                <xsl:value-of select="ec2:cidrIp"/>
            </xsl:element>
        </xsl:for-each>
    </xsl:template>

  <xsl:template match="ec2:tagSet">
    <xsl:for-each select="ec2:item">
      <xsl:element name="Tag">
        <xsl:element name="Key">
          <xsl:value-of select="ec2:key" />
        </xsl:element>
        <xsl:element name="Value">
          <xsl:value-of select="ec2:value" />
        </xsl:element>
      </xsl:element>
    </xsl:for-each>
  </xsl:template>

</xsl:stylesheet>
