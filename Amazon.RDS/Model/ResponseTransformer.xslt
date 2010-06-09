<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform" xmlns:aws="http://rds.amazonaws.com/admin/2009-10-16/" exclude-result-prefixes="aws">
  <xsl:output method="xml" omit-xml-declaration="yes" indent="yes"/>
  <xsl:variable name="ns" select="'http://rds.amazonaws.com/admin/2009-10-16/'"/>

  <!-- Skip the RDS wrapped list elements -->
  <xsl:template match="*[(local-name()='Events'              and local-name(child::*)='Event') 
                        or (local-name()='DBParameterGroups' and local-name(child::*)='DBParameterGroup')
                        or (local-name()='DBInstances'       and local-name(child::*)='DBInstance')
                        or (local-name()='DBSecurityGroups'  and local-name(child::*)='DBSecurityGroup')
                        or (local-name()='DBSecurityGroups'  and local-name(child::*)='DBSecurityGroupName')
                        or (local-name()='DBSnapshots'       and local-name(child::*)='DBSnapshot')
                        or (local-name()='EC2SecurityGroups' and local-name(child::*)='EC2SecurityGroup')
                        or (local-name()='IPRanges'          and local-name(child::*)='IPRange')
                        or (local-name()='Parameters'        and local-name(child::*)='Parameter')]">
    <xsl:apply-templates/>
  </xsl:template>

  <xsl:template match="node() | @*">
    <xsl:if test="count(descendant::text()[string-length(.)>0]|*)">
      <xsl:copy>
        <xsl:apply-templates select="@*|node()" />
      </xsl:copy>
    </xsl:if>
  </xsl:template>

  <xsl:template match="text()">
    <xsl:value-of select="." />
  </xsl:template>
</xsl:stylesheet>

