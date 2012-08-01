<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform" xmlns:ec2="default-ec2-namespace" exclude-result-prefixes="ec2">
    <xsl:output method="xml" omit-xml-declaration="no" indent="yes"/>
    <xsl:template match="ec2:CreateSnapshotResponse">
        <xsl:element name="CreateSnapshotResponse">
            <xsl:element name="ResponseMetadata">
                <xsl:element name="RequestId">
                    <xsl:value-of select="ec2:requestId"/>
                </xsl:element>
            </xsl:element>
            <xsl:element name="CreateSnapshotResult">
                <xsl:element name="Snapshot">
                    <xsl:element name="SnapshotId">
                        <xsl:value-of select="ec2:snapshotId"/>
                    </xsl:element>
                    <xsl:element name="VolumeId">
                        <xsl:value-of select="ec2:volumeId"/>
                    </xsl:element>
                  <xsl:element name="VolumeSize">
                    <xsl:value-of select="ec2:volumeSize"/>
                  </xsl:element>
                    <xsl:element name="Status">
                        <xsl:value-of select="ec2:status"/>
                    </xsl:element>
                    <xsl:element name="StartTime">
                        <xsl:value-of select="ec2:startTime"/>
                    </xsl:element>
                    <xsl:element name="Progress">
                        <xsl:value-of select="ec2:progress"/>
                    </xsl:element>
                    <xsl:element name="OwnerId">
                        <xsl:value-of select="ec2:ownerId"/>
                    </xsl:element>
                    <xsl:element name="Description">
                        <xsl:value-of select="ec2:description"/>
                    </xsl:element>
                    <xsl:element name="OwnerAlias">
                        <xsl:value-of select="ec2:ownerAlias" />
                    </xsl:element>
                </xsl:element>
            </xsl:element>
        </xsl:element>
    </xsl:template>
</xsl:stylesheet>
