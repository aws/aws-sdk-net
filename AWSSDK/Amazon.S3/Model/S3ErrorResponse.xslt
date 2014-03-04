<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform" xmlns:s3="http://s3.amazonaws.com/doc/2006-03-01/" exclude-result-prefixes="xsl s3">
	<xsl:output method="xml" omit-xml-declaration="no" indent="yes"/>
	<xsl:variable name="ns" select="'http://s3.amazonaws.com/doc/2006-03-01/'"/>

	<xsl:template match="Error">
		<xsl:element name="S3Error">
      <Code>
        <xsl:value-of select="Code"/>
      </Code>
      <Message>
        <xsl:value-of select="Message"/>
      </Message>
      <HostId>
        <xsl:value-of select="HostId"/>
      </HostId>
      <RequestId>
        <xsl:value-of select="RequestId"/>
      </RequestId>
      <UploadId>
        <xsl:value-of select="UploadId"/>
      </UploadId>
      <ETag>
        <xsl:value-of select="ETag"/>
      </ETag>
    </xsl:element>
	</xsl:template>
</xsl:stylesheet>