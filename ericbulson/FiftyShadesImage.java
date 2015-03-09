import java.awt.Color;
import java.awt.Graphics;
import java.awt.image.BufferedImage;
import java.io.File;
import java.io.IOException;

import javax.imageio.ImageIO;

public class FiftyShadesImage {

	public static void main(String[] args) throws IOException {
		int width = 1000;
		int height = 20;
		BufferedImage img = new BufferedImage(width,height,BufferedImage.TYPE_INT_ARGB);
		Graphics g = img.getGraphics();
		for (int i = 0; i < 51; i++) {
			Color c = new Color(60 + 2*i, 60 + 2*i, 60 + 2*i);
			g.setColor(c);
			g.fillRect(0 + i * 20, 0, 20, 20);
		}		
		File outputfile = new File("fiftygrey.png");
		ImageIO.write(img, "png", outputfile);
	}
}
