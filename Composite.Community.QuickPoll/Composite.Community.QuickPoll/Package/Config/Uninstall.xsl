<?xml version="1.0"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
	<xsl:template match="@* | node()">
		<xsl:copy>
			<xsl:apply-templates select="@* | node()" />
		</xsl:copy>
	</xsl:template>
	<xsl:template match="/configuration/Composite.C1Console.Forms.Plugins.ProducerMediatorConfiguration/Mediators/add[@name='http://www.composite.net/ns/Composite/Community/QuickPoll/1.0']" />
	<xsl:template match="/configuration/Composite.C1Console.Forms.Plugins.UiControlFactoryConfiguration/Channels/Channel[@name='AspNet.Management']/Namespaces/Namespace[@name='http://www.composite.net/ns/Composite/Community/QuickPoll/1.0']" />
</xsl:stylesheet>