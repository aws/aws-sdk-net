<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet version="1.0"
	xmlns:xsl="http://www.w3.org/1999/XSL/Transform" xmlns:ec2="http://ec2.amazonaws.com/doc/2012-05-01/"
	exclude-result-prefixes="ec2">
	<xsl:output method="xml" omit-xml-declaration="no" indent="yes" />
	<xsl:variable name="ns"
		select="'http://ec2.amazonaws.com/doc/2012-05-01/'" />
	<xsl:template match="ec2:DescribeSnapshotAttributeResponse">
		<xsl:element name="DescribeSnapshotAttributeResponse"
			namespace="{$ns}">
			<xsl:element name="ResponseMetadata" namespace="{$ns}">
				<xsl:element name="RequestId" namespace="{$ns}">
					<xsl:value-of select="ec2:requestId" />
				</xsl:element>
			</xsl:element>
			<xsl:element name="DescribeSnapshotAttributeResult"
				namespace="{$ns}">
				<xsl:element name="SnapshotAttribute" namespace="{$ns}">
					<xsl:element name="SnapshotId" namespace="{$ns}">
						<xsl:value-of select="ec2:snapshotId" />
					</xsl:element>
					<xsl:apply-templates select="ec2:createVolumePermission" />
          <xsl:apply-templates select="ec2:productCodes"/>
        </xsl:element>
			</xsl:element>
		</xsl:element>
	</xsl:template>
	<xsl:template match="ec2:createVolumePermission">
		<xsl:for-each select="ec2:item">
			<xsl:element name="CreateVolumePermission" namespace="{$ns}">
				<xsl:element name="UserId" namespace="{$ns}">
					<xsl:value-of select="ec2:userId" />
				</xsl:element>
				<xsl:element name="GroupName" namespace="{$ns}">
					<xsl:value-of select="ec2:group" />
				</xsl:element>
			</xsl:element>
		</xsl:for-each>
	</xsl:template>
  <xsl:template match="ec2:productCodes">
    <xsl:for-each select="ec2:item">
      <xsl:element name="ProductCodes" namespace="{$ns}">
        <xsl:element name="ProductCodeId" namespace="{$ns}">
          <xsl:value-of select="ec2:productCode"/>
        </xsl:element>
        <xsl:element name="Type" namespace="{$ns}">
          <xsl:value-of select="ec2:type"/>
        </xsl:element>
      </xsl:element>
    </xsl:for-each>
  </xsl:template>
</xsl:stylesheet>
