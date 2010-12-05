<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform" xmlns:ec2="http://ec2.amazonaws.com/doc/2010-08-31/" exclude-result-prefixes="ec2">
  <xsl:output method="xml" omit-xml-declaration="no" indent="yes"/>
  <xsl:variable name="ns" select="'http://ec2.amazonaws.com/doc/2010-08-31/'"/>
  <xsl:template match="ec2:ImportKeyPairResponse">
    <xsl:element name="ImportKeyPairResponse" namespace="{$ns}">
      <xsl:element name="ResponseMetadata" namespace="{$ns}">
        <xsl:element name="RequestId" namespace="{$ns}">
          <xsl:value-of select="ec2:requestId"/>
        </xsl:element>
      </xsl:element>
      <xsl:element name="ImportKeyPairResult" namespace="{$ns}">
        <xsl:element name="KeyName" namespace="{$ns}">
          <xsl:value-of select="ec2:keyName"/>
        </xsl:element>
        <xsl:element name="KeyFingerprint" namespace="{$ns}">
          <xsl:value-of select="ec2:keyFingerprint"/>
        </xsl:element>
      </xsl:element>
    </xsl:element>
  </xsl:template>
</xsl:stylesheet>
