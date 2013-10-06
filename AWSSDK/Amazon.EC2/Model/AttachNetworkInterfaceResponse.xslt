﻿<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform" xmlns:ec2="default-ec2-namespace" exclude-result-prefixes="ec2">
  <xsl:output method="xml" omit-xml-declaration="no" indent="yes"/>

  <xsl:template match="ec2:AttachNetworkInterfaceResponse">
    <xsl:element name="AttachNetworkInterfaceResponse">
      <xsl:element name="ResponseMetadata">
        <xsl:element name="RequestId">
          <xsl:value-of select="ec2:requestId"/>
        </xsl:element>
      </xsl:element>
      <xsl:element name="AttachNetworkInterfaceResult">
        <xsl:element name="AttachmentId">
          <xsl:value-of select="ec2:attachmentId"/>
        </xsl:element>
      </xsl:element>
    </xsl:element>
  </xsl:template>

</xsl:stylesheet>
