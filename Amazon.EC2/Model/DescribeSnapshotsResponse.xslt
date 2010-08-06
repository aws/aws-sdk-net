<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet version="1.0"
  xmlns:xsl="http://www.w3.org/1999/XSL/Transform" xmlns:ec2="http://ec2.amazonaws.com/doc/2010-06-15/"
  exclude-result-prefixes="ec2">
  <xsl:output method="xml" omit-xml-declaration="no" indent="yes" />
  <xsl:variable name="ns"
    select="'http://ec2.amazonaws.com/doc/2010-06-15/'" />
  <xsl:template match="ec2:DescribeSnapshotsResponse">
    <xsl:element name="DescribeSnapshotsResponse" namespace="{$ns}">
      <xsl:element name="ResponseMetadata" namespace="{$ns}">
        <xsl:element name="RequestId" namespace="{$ns}">
          <xsl:value-of select="ec2:requestId" />
        </xsl:element>
      </xsl:element>
      <xsl:element name="DescribeSnapshotsResult" namespace="{$ns}">
        <xsl:apply-templates select="ec2:snapshotSet" />
      </xsl:element>
    </xsl:element>
  </xsl:template>
  <xsl:template match="ec2:snapshotSet">
    <xsl:for-each select="ec2:item">
      <xsl:element name="Snapshot" namespace="{$ns}">
        <xsl:element name="SnapshotId" namespace="{$ns}">
          <xsl:value-of select="ec2:snapshotId" />
        </xsl:element>
        <xsl:element name="VolumeId" namespace="{$ns}">
          <xsl:value-of select="ec2:volumeId" />
        </xsl:element>
        <xsl:element name="VolumeSize" namespace="{$ns}">
          <xsl:value-of select="ec2:volumeSize" />
        </xsl:element>
        <xsl:element name="Status" namespace="{$ns}">
          <xsl:value-of select="ec2:status" />
        </xsl:element>
        <xsl:element name="StartTime" namespace="{$ns}">
          <xsl:value-of select="ec2:startTime" />
        </xsl:element>
        <xsl:element name="Progress" namespace="{$ns}">
          <xsl:value-of select="ec2:progress" />
        </xsl:element>
        <xsl:element name="OwnerId" namespace="{$ns}">
          <xsl:value-of select="ec2:ownerId" />
        </xsl:element>
        <xsl:element name="Description" namespace="{$ns}">
          <xsl:value-of select="ec2:description" />
        </xsl:element>
        <xsl:element name="OwnerAlias" namespace="{$ns}">
          <xsl:value-of select="ec2:ownerAlias" />
        </xsl:element>
      </xsl:element>
    </xsl:for-each>
  </xsl:template>
</xsl:stylesheet>