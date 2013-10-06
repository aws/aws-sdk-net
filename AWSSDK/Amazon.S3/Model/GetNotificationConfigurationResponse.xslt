<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform" xmlns:s3="http://s3.amazonaws.com/doc/2006-03-01/" exclude-result-prefixes="xsl s3">
  <xsl:output method="xml" omit-xml-declaration="no" indent="yes"/>
  <xsl:variable name="ns" select="'http://s3.amazonaws.com/doc/2006-03-01/'"/>

  <xsl:template match="s3:NotificationConfiguration">
    <GetNotificationConfigurationResponse  xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance" xmlns:xsd="http://www.w3.org/2001/XMLSchema">
      <NotificationConfiguration>
        <TopicConfigurations>
        <xsl:apply-templates/>
        </TopicConfigurations>
      </NotificationConfiguration>
    </GetNotificationConfigurationResponse>
  </xsl:template>
  
  <xsl:template match="s3:TopicConfiguration">
    <TopicConfiguration>
      <Event>
        <xsl:value-of select="s3:Event"/>
      </Event>
      <Topic>
        <xsl:value-of select="s3:Topic"/>
      </Topic>
    </TopicConfiguration>
  </xsl:template>
</xsl:stylesheet>
