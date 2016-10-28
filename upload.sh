cd /home/travis/build/alexr03/RocketPluginTemplate/

#!/bin/sh
HOST='ftp.solarsentinels.co.uk/public_html/'
USER='solar'
PASSWD='Uv#-j!bbQ"f_Qv66'
FILE='bin/debug/RocketPluginTemplate.dll'

ftp -n $HOST <<END_SCRIPT
quote USER $USER
quote PASS $PASSWD
put $FILE
quit
END_SCRIPT
exit 0
