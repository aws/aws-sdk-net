<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform" xmlns:s3="http://s3.amazonaws.com/doc/2006-03-01/" exclude-result-prefixes="xsl s3">
  <xsl:output method="xml" omit-xml-declaration="no" indent="yes"/>
  <xsl:variable name="ns" select="'http://s3.amazonaws.com/doc/2006-03-01/'"/>

  <xsl:template match="s3:WebsiteConfiguration">
    <xsl:element name="GetBucketWebsiteResponse">
      <xsl:element name="WebsiteConfiguration">
        <xsl:apply-templates/>
      </xsl:element>
    </xsl:element>
  </xsl:template>

  <xsl:template match="s3:Suffix">
    <xsl:element name="IndexDocumentSuffix">
      <xsl:value-of select="."/>
    </xsl:element>
  </xsl:template>

  <xsl:template match="s3:Key">
    <xsl:element name="ErrorDocument">
      <xsl:value-of select="."/>
    </xsl:element>
  </xsl:template>

  <xsl:template match="s3:RedirectAllRequestsTo">
    <xsl:element name="RedirectAllRequestsTo">
      <xsl:element name="Protocol">
        <xsl:value-of select="s3:Protocol" />
      </xsl:element>
      <xsl:element name="HostName">
        <xsl:value-of select="s3:HostName" />
      </xsl:element>
      <xsl:element name="ReplaceKeyPrefixWith">
        <xsl:value-of select="s3:ReplaceKeyPrefixWith" />
      </xsl:element>
      <xsl:element name="ReplaceKeyWith">
        <xsl:value-of select="s3:ReplaceKeyWith" />
      </xsl:element>
      <xsl:element name="HttpRedirectCode">
        <xsl:value-of select="s3:HttpRedirectCode" />
      </xsl:element>
    </xsl:element>
  </xsl:template>

  <xsl:template match="s3:RoutingRules">
    <xsl:element name="RoutingRules">
      <xsl:apply-templates/>
    </xsl:element>
  </xsl:template>
  
  <xsl:template match="s3:RoutingRule">
    <xsl:element name="RoutingRule">

      <xsl:apply-templates mode="RoutingRules"/>
      
    </xsl:element>
  </xsl:template>

  <xsl:template match="s3:Condition" mode="RoutingRules">
    <xsl:element name="Condition">
      <xsl:element name="KeyPrefixEquals">
        <xsl:value-of select="s3:KeyPrefixEquals" />
      </xsl:element>
      <xsl:element name="HttpErrorCodeReturnedEquals">
        <xsl:value-of select="s3:HttpErrorCodeReturnedEquals" />
      </xsl:element>
    </xsl:element>
  </xsl:template>

  <xsl:template match="s3:Redirect" mode="RoutingRules">
    <xsl:element name="Redirect">
      <xsl:element name="Protocol">
        <xsl:value-of select="s3:Protocol" />
      </xsl:element>
      <xsl:element name="HostName">
        <xsl:value-of select="s3:HostName" />
      </xsl:element>
      <xsl:element name="ReplaceKeyPrefixWith">
        <xsl:value-of select="s3:ReplaceKeyPrefixWith" />
      </xsl:element>
      <xsl:element name="ReplaceKeyWith">
        <xsl:value-of select="s3:ReplaceKeyWith" />
      </xsl:element>
      <xsl:element name="HttpRedirectCode">
        <xsl:value-of select="s3:HttpRedirectCode" />
      </xsl:element>
    </xsl:element>
  </xsl:template>
  
</xsl:stylesheet>