<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet version="1.0"
	xmlns:xsl="http://www.w3.org/1999/XSL/Transform" xmlns:ec2="default-ec2-namespace"
	exclude-result-prefixes="ec2">
	<xsl:output method="xml" omit-xml-declaration="no" indent="yes" />
	<xsl:template match="ec2:DescribeSnapshotAttributeResponse">
		<xsl:element name="DescribeSnapshotAttributeResponse">
			<xsl:element name="ResponseMetadata">
				<xsl:element name="RequestId">
					<xsl:value-of select="ec2:requestId" />
				</xsl:element>
			</xsl:element>
			<xsl:element name="DescribeSnapshotAttributeResult">
				<xsl:element name="SnapshotAttribute">
					<xsl:element name="SnapshotId">
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
			<xsl:element name="CreateVolumePermission">
				<xsl:element name="UserId">
					<xsl:value-of select="ec2:userId" />
				</xsl:element>
				<xsl:element name="GroupName">
					<xsl:value-of select="ec2:group" />
				</xsl:element>
			</xsl:element>
		</xsl:for-each>
	</xsl:template>
  <xsl:template match="ec2:productCodes">
    <xsl:for-each select="ec2:item">
      <xsl:element name="ProductCodes">
        <xsl:element name="ProductCodeId">
          <xsl:value-of select="ec2:productCode"/>
        </xsl:element>
        <xsl:element name="Type">
          <xsl:value-of select="ec2:type"/>
        </xsl:element>
      </xsl:element>
    </xsl:for-each>
  </xsl:template>
</xsl:stylesheet>
