<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform" xmlns:s3="http://s3.amazonaws.com/doc/2006-03-01/" exclude-result-prefixes="xsl s3">
  <xsl:output method="xml" omit-xml-declaration="no" indent="yes"/>
  <xsl:variable name="ns" select="'http://s3.amazonaws.com/doc/2006-03-01/'"/>

  <xsl:template match="s3:ListPartsResult">
    <ListPartsResponse>
      <BucketName>
        <xsl:value-of select="s3:Bucket"/>
      </BucketName>
      <Key>
        <xsl:value-of select="s3:Key"/>
      </Key>
      <UploadId>
        <xsl:value-of select="s3:UploadId"/>
      </UploadId>
      <StorageClass>
        <xsl:value-of select="s3:StorageClass"/>
      </StorageClass>
      <PartNumberMarker>
        <xsl:value-of select="s3:PartNumberMarker"/>
      </PartNumberMarker>
      <NextPartNumberMarker>
        <xsl:value-of select="s3:NextPartNumberMarker"/>
      </NextPartNumberMarker>
      <MaxParts>
        <xsl:value-of select="s3:MaxParts"/>
      </MaxParts>
      <IsTruncated>
        <xsl:value-of select="s3:IsTruncated"/>
      </IsTruncated>

      <Owner>
        <xsl:apply-templates select="s3:Owner"/>
      </Owner>

      <Initiator>
        <xsl:apply-templates select="s3:Owner"/>
      </Initiator>

      <Parts>
        <xsl:apply-templates select="s3:Part"/>
      </Parts>


    </ListPartsResponse>
  </xsl:template>

  <xsl:template match="s3:Part">
    <PartDetail>
      <PartNumber>
        <xsl:value-of select="s3:PartNumber"/>
      </PartNumber>
      <LastModified>
        <xsl:value-of select="s3:LastModified"/>
      </LastModified>
      <ETag>
        <xsl:value-of select="s3:ETag"/>
      </ETag>
      <Size>
        <xsl:value-of select="s3:Size"/>
      </Size>
    </PartDetail>
  </xsl:template>
  
  <xsl:template match="s3:Owner">    
      <Id>
        <xsl:value-of select="s3:ID"/>
      </Id>
      <DisplayName>
        <xsl:value-of select="s3:DisplayName"/>
      </DisplayName>
  </xsl:template>

</xsl:stylesheet>
